namespace ContadorPalabras.Models
{
    public static class SistemaTextosArchivo
    {
        private static string archivo = "textos.txt"; 
        
        private static Stack<string> textos = new Stack<string>();

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
                    textos.Push(linea);
                }
            }
        }

        public static Stack<string> ObtenerTextos() => textos;
        public static void AgregarTexto(string texto) => textos.Push(texto);
    }
}
