/*
    consigna:
    Carlos quiere llevar un registro de todas las páginas web que visita en un día.
    Quiere que las páginas se registren en el orden en que fueron visitadas y le gustaría
    poder retroceder a la página anterior si es necesario.

    Permite:
        1. Agregar una nueva página al historial.
        2. Retroceder a la página anterior.
        3. Mostrar la página actual y el historial completo.
 */

class Program
{
    static void Main()
    {
        Stack<string> historial = new Stack<string>();

        int opcion;

        do
        {
            Console.WriteLine("1. Visitar nueva página");
            Console.WriteLine("2. Retroceder página");
            Console.WriteLine("3. Mostrar historial");
            Console.WriteLine("4. Salir\n");
            // happy path, el usuario pondrá un numero.
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la URL de la página: ");
                    string url = Console.ReadLine();
                    historial.Push(url);
                    Console.WriteLine($"Visitando: {url}\n");
                    break;

                case 2:
                    if(historial.Count > 0)
                    {
                        string paginaAnterior = historial.Pop();
                        Console.WriteLine($"Retrocediendo desde: {paginaAnterior}\n");
                    }
                    else
                    {
                        Console.WriteLine("No hay más páginas en el historial.\n");
                    }
                    break;

                case 3:
                    Console.WriteLine("Historial de navegacion:");
                    foreach (var pagina in historial)
                    {
                        Console.WriteLine(pagina);
                    }
                    Console.WriteLine("\n");
                    break;
            }
        }
        while (opcion != 4);

        Console.WriteLine("Pulse cualquier tecla para salir.");
    }
}