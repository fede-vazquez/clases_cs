/*
    En una empresa tecnológica, un equipo de soporte técnico necesita gestionar una gran cantidad
    de tickets de usuarios que reportan problemas. Para facilitar esta tarea, el departamento de TI
    ha desarrollado un sistema automatizado que les permite agregar y procesar solicitudes de manera eficiente.
    Cada vez que un cliente reporta un problema, el sistema asigna un número de ticket único y lo coloca
    en una cola para ser atendido en orden de llegada. El desafío del programador es diseñar este
    sistema de tickets, permitiendo a los técnicos ver la lista de problemas pendientes y procesar los tickets
    uno por uno, asegurando que ningún problema quede sin resolver. ¿Podrás construir este sistema de soporte
    eficiente para ayudar al equipo técnico a mantenerse organizado?
 */

// SistemaTickets puede ser static.
// la clase static es un objeto individual sin estanciarlo, y todos sus métodos son static.
// permite utilizar la clase sin instanciarla.
class Ticket
{
    public int Id { get; set; }
    public string Descripcion { get; set; }

    public Ticket(int id, string descripcion)
    {
        Id = id;
        Descripcion = descripcion;
    }
}

class SistemaTickets
{
    private Queue<Ticket> cola = new Queue<Ticket>();
    private int siquienteId = 1;

    public void AgregarTicket(string descripcion)
    {
        Ticket nuevoTicket = new Ticket(siquienteId++, descripcion);
        cola.Enqueue(nuevoTicket);
        Console.WriteLine($"Ticket #{nuevoTicket.Id} agregado : {nuevoTicket.Descripcion}");
    }

    public void ProcesarTicket()
    {
        if(cola.Count == 0)
        {
            Console.WriteLine("No hay tickets para procesar");
            return;
        }

        Ticket ticket = cola.Dequeue();
        Console.WriteLine($"Procesando ticket #{ticket.Id}: {ticket.Descripcion}");
    }

    public void MostrarTickets()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("No hay tickets pendientes");
            return;
        }
        Console.WriteLine("Tickets pendientes:");
        foreach(var t in cola)
        {
            Console.WriteLine($"Ticket #{t.Id}: {t.Descripcion}");
        }
    }
}
class Program
{
    static void Main()
    {
        SistemaTickets sistema = new SistemaTickets();
        string opcion;
        do
        {
            Console.WriteLine("=== Menu de opciones ===");
            Console.WriteLine("1. Agregar nuevo ticket");
            Console.WriteLine("2. Mostrar Ticket");
            Console.WriteLine("3. Procesar Ticket");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccionar una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la descripción del Ticket: ");
                    string descripcion = Console.ReadLine();
                    sistema.AgregarTicket(descripcion);
                    break;

                case "2":
                    sistema.ProcesarTicket();
                    break;

                case "3":
                    sistema.MostrarTickets();
                    break;

                case "4":
                    Console.WriteLine("Saliento");
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        } while (opcion != "4");
    }
}