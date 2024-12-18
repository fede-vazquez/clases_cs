﻿namespace ContadorPalabras.Models
{
    public static class Sistema
    {
        private static List<string> textos = SistemaTextosArchivo.ObtenerTextos().ToList();

        private static Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

        private static string textoActual;

        public static void AgregarTexto()
        {
            Console.Write("Ingrese un texto: ");
            textoActual = Console.ReadLine();

            textos.Add(textoActual);
            SistemaTextosArchivo.AgregarTexto(textoActual);
        }
        public static void CalcularFrecuenciaPalabras()
        {
            if (contadorPalabras.Count >= 0) contadorPalabras.Clear();

            if (textoActual != "")
            {
                string[] palabras = textoActual.Split(" ");
                foreach (var palabra in palabras)
                {
                    if (contadorPalabras.ContainsKey(palabra))
                    {
                        contadorPalabras[palabra]++;
                    }
                    else
                    {
                        contadorPalabras.Add(palabra, 1);
                    }
                }
            }
            else
            {
                Console.WriteLine("El texto actual está vacío.");
            }
        }

        public static void MostrarFrecuenciaPalabras()
        {
            Console.WriteLine("Frecuencia de palabras del texto: ");
            foreach (var entrada in contadorPalabras)
            {
                Console.WriteLine($"{entrada.Key}: {entrada.Value}");
            }
        }

        public static void ListarTextos()
        {
            Console.WriteLine("Textos anteriores: ");
            if (textos.Count > 0)
            {
                for (int i = 0; i < textos.Count; i++)
                {
                    Console.WriteLine($"{i+1}: {textos[i]}");
                }
            }
            else
            {
                Console.WriteLine("No hay textos guardadas.");
            }
        }

        public static void CambiarTextoActual()
        {
            ListarTextos();
            
            if(textos.Count > 0)
            {
                Console.Write("Seleccione el texto para mostrar su frecuencia: ");
                int indice = int.Parse(Console.ReadLine()) - 1;
                if (textos[indice] != null)
                {
                    textoActual = textos[indice];
                    CalcularFrecuenciaPalabras();
                }
                else
                {
                    Console.WriteLine("Indice fuera de rango.");
                }
            }
        }
    }
}