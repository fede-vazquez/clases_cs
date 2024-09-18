using System.Collections;
class Program
{
    static void Main()
    {
        //IEnumerable<int> numeros;
        //ICollection<int> numbers;
        //List<int> list;
        //int[x,y] matriz;
        //HashSet<int> set;
        
        //int[] numeritos = { 1, 2, 3, 4, 5, 6, 7 };
        //for(int i = 0; i < numeritos.Length; i++)
        //{
        //    Console.WriteLine(numeritos[i]);
        //}

        // array de string que tenga 5 frutas.
        //string[] frutas = { "Manzana", "Pera", "Banana", "Piña", "Uva" };
        //for(int i = 0; i < frutas.Length; i++)
        //{
        //    Console.WriteLine(frutas[i]);
        //}

        // dada una lista desordenada de numeros, ordenarla de forma ascendente con programacion estructurada.

        //int[] numeros = { 1, 4, 6, 8, 5, 3, 2, 12 };
        //for(int i = 0;i < (numeros.Length - 1); i++)
        //{
        //    for(int j = i+1; j < numeros.Length; j++)
        //    {
        //        if (numeros[i] > numeros[j])
        //        {
        //            int aux = numeros[j];
        //            numeros[j] = numeros[i];
        //            numeros[i] = aux;
        //        }
        //    }
        //}
        
        //for (int i = 0; i < numeros.Length; i++)
        //{
        //    Console.WriteLine(numeros[i]);
        //}

        // Hacer lista de numeros

        //List<int> numeros = new List<int>();
        //int[] numeros2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        // int[] arrayEspecifico = new int[4];
        
        // numeros2[numeros2.Length] = 12; // No se puede expandir un array, las listas si.

        //for(int i = 0; i < numeros2.Length; i++)
        //{
        //    Console.WriteLine(numeros2[i]);
        //}


        // -----------------------------------------------------------------

        //IDictionary<char, string> letras = new Dictionary<char, string>();

        //letras.Add('A', "A");
        //letras.Add('B', "Be");
        //letras.Add('C', "Ce");
        //letras.Add('D', "De");
        //letras.Add('E', "E");
        //letras.Add('F', "Efe");

        //Console.WriteLine(letras['F']);
        
        // -----------------------------------------------------------------

        // Diccionario de 5 palabras en ingles con traduccion en español.

        //IDictionary<string, string> palabras = new Dictionary<string, string>();

        //palabras.Add("Dog", "Perro");
        //palabras.Add("Cat", "Gato");
        //palabras.Add("Window", "Ventana");
        //palabras.Add("Console", "Consola");
        //palabras.Add("Keyboard", "Teclado");

        ////Console.WriteLine(palabras["Dog"]);

        //foreach(var kvp in palabras)
        //{
        //    Console.WriteLine(kvp.Value);
        //}


        // -----------------------------------------------------------------
        // los sets son estructuras de datos donde los datos que hay dentro no se tienen que repetir.

        HashSet<int> list = new HashSet<int>();

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(3); // esto no se agrega, ya que no se puede repetir.

        Console.WriteLine(list.Contains(3)); // devuelve true o false si existe el valor.
        foreach (int num in list)
        {
            Console.WriteLine(num);
        }

        // -----------------------------------------------------------------

        //Queue cola;
        //Stack<int> stack;
    }
}