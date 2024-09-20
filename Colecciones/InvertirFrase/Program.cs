// Ejemplo para usar el debuger
public class Program
{
    static void Main()
    {
        Stack<char> pila = new Stack<char>();

        Console.Write("Escriba la frase: ");
        string frase = Console.ReadLine();

        foreach (var letra in frase)
        {
            pila.Push(letra);
        }

        Console.WriteLine("Frase invertida: ");

        while(pila.Count > 0)
        {
            Console.Write(pila.Pop());
        }
    }
}   