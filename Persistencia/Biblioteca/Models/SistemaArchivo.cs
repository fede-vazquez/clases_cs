namespace Biblioteca.Models
{
    static class SistemaArchivo
    {
        public static void GuardarDato<T>(string nombreArchivo, T dato, bool isAppend = false) where T : class
        {
            using StreamWriter writer = new StreamWriter(nombreArchivo, isAppend);
            writer.WriteLine(nombreArchivo);
        }

        public static List<string> CargarDatos(string nombreArchivo)
        {
            var datos = new List<string>();

            if (File.Exists(nombreArchivo))
            {
                using StreamReader reader = new StreamReader(nombreArchivo);

                string linea;

                while((linea = reader.ReadLine()) != null)
                {
                    datos.Add(linea);
                }
            }
            return datos;
        }
    }
}