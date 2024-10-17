using AgenciaEspacial.Enums;

namespace AgenciaEspacial.Models
{
    public static class SysArchivo
    {
        public static string archivoMisiones = "misiones.txt";

        public static void GuardarDatos(List<Mision> misiones)
        {
            using StreamWriter writer = new StreamWriter(archivoMisiones);

            foreach (var mision in misiones)
            {
                Console.WriteLine(mision);
                writer.WriteLine(mision);
            }
        }

        public static void GuardarMision(Mision mision)
        {
            using StreamWriter writer = new StreamWriter(archivoMisiones, true);
            writer.WriteLine(mision);
        }

        public static List<Mision> CargarDatos()
        {
            List<Mision> misiones = new List<Mision>();

            if (File.Exists(archivoMisiones))
            {
                using StreamReader reader = new StreamReader(archivoMisiones);

                foreach (var linea in File.ReadAllLines(archivoMisiones))
                {
                    string[] p = linea.Split(", ");

                    // esto podría ser un enum.
                    string tipoMision = p[0];
                    string nombre = p[1];
                    Destino destino = (Destino)Enum.Parse(typeof(Destino), p[2]);
                    int astronautas = int.Parse(p[3]);

                    Mision m = null;
                    switch (tipoMision)
                    {
                        case "Exploracion":
                            m = new Exploracion(nombre, destino, astronautas);
                            break;
                        case "Colonizacion":
                            int colonos = int.Parse(p[4]);
                            m = new Colonizacion(nombre, destino, astronautas, colonos);
                            break;
                        case "Investigacion":
                            string campoInvestigacion = p[4];
                            m = new Investigacion(nombre, destino, astronautas, campoInvestigacion);
                            break;
                    }
                    misiones.Add(m);
                }
            }

            return misiones;
        }
    }
}

// Hacer un enum para el tipo de misión y un switch parseandolo para compararlo en un switch