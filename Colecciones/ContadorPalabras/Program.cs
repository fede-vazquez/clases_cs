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
            }
            else
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

// Pila, porque no se enumera, me van quedando en el orden en el que las ingreso, y no las voy a modificar.
// Un menú con estas opciones:
// Agregar frases y mostrar frecuencia.
// Listar frases.
// Elegir una y mostrar la frecuencia.