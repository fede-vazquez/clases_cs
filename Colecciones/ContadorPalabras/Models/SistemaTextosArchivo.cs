namespace ContadorPalabras.Models
{
    public static class SistemaTextosArchivo
    {
        private static string archivo = "textos.txt"; 
        
        // No sé por qué si uso Stack me modifíca el orden
        // de los textos al guardarlos en el archivo.
        // Creo que es porque en los stacks el orden se invierte, por LIFO.
        private static Queue<string> textos = new Queue<string>();

        public static void GuardarEnArchivo()
        {
            using StreamWriter writer = new StreamWriter(archivo);

            foreach (var t in textos)
            {
                writer.WriteLine(t);
            }
        }

        public static void CargarDeArchivo()
        {
            if (File.Exists(archivo))
            {
                using StreamReader reader = new StreamReader(archivo);

                string linea;
                while((linea = reader.ReadLine()) != null)
                {
                    textos.Enqueue(linea);
                }
            }
        }

        public static Queue<string> ObtenerTextos() => textos;
        public static void AgregarTexto(string texto) => textos.Enqueue(texto);
    }
}
