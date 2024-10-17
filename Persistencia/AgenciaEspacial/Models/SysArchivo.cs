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

    }
}
