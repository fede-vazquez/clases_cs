public class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un texto: ");
        string texto = Console.ReadLine();

        Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

        string[] palabras = texto.Split(" ");

        foreach (var palabra in palabras)
        {
            if (contadorPalabras.ContainsKey(palabra)){
            contadorPalabras[palabra]++;
            }else
            {
                contadorPalabras.Add(palabra, 1);
            }
        }

        Console.WriteLine("\n");
        Console.WriteLine("Frecuencia de palabras: ");
        foreach(var entrada in contadorPalabras)
        {
            Console.WriteLine($"{entrada.Key}: {entrada.Value}");
        }
    }
}