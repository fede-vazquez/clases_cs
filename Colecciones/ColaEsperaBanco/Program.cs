using ColaEsperaBanco.Models;

public class Program
{
    static void Main()
    {
        Queue<Cliente> colaBanco = new Queue<Cliente>();

        int opcion;

        do
        {
            Console.WriteLine("1. Agregar cliente a la cola.");
            Console.WriteLine("2. Atender al cliente que está en la primera posición.");
            Console.WriteLine("3. Mostrar clientes que están en la cola.");
            Console.WriteLine("4. Salir.");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (opcion)
            {
                case 1:
                    Console.Write("Agrega nombre del cliente: ");
                    string nombreCliente = Console.ReadLine();

                    Console.Write("Agrega número de cliente: ");
                    int nroCliente = int.Parse(Console.ReadLine());

                    Cliente c = new Cliente(nombreCliente, nroCliente);

                    colaBanco.Enqueue(c);
                    Console.WriteLine($"El cliente {c.Nombre} se agrego a la cola.");
                    Console.WriteLine("\n");
                    break;

                case 2:
                    if(colaBanco.Count > 0)
                    {
                        Cliente clienteAtendido = colaBanco.Dequeue();
                        Console.WriteLine($"Atendiendo a: {clienteAtendido.Nombre}, {clienteAtendido.NumeroCliente}");
                    }
                    else
                    {
                        Console.WriteLine("No hay clientes en la cola");
                    }
                    break;

                case 3:
                    Console.WriteLine("Clientes en la cola:");
                    foreach(Cliente cliente in colaBanco)
                    {
                        Console.WriteLine($"{cliente.Nombre}, {cliente.NumeroCliente}");
                    }
                    Console.WriteLine("\n");
                    break;
            }

        } while (opcion != 4);
    }
}