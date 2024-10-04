namespace Almacen.Models
{
    public static class SistemaArchivo
    {
        public static void GuardarDato<T>(string nombreArchivo, T data, bool isAppend = false) where T : class
        {
            using StreamWriter writer = new StreamWriter(nombreArchivo, isAppend);

            if (data != null)
            {
                writer.WriteLine(data);
                Console.WriteLine("Datos guardados correctamente en el archivo.");
            }
            else
            {
                Console.WriteLine("No hay un dato para guardar.");
            }
        }

        public static List<string> ObtenerDatos(string nombreArchivo, bool isAppend = false)
        {
            using StreamReader reader = new StreamReader(nombreArchivo, isAppend);

            List<string> datos = new List<string>();

            string linea;

            while((linea = reader.ReadLine()) != null)
            {
                datos.Add(linea);
            }

            return datos;
        }
    }
}