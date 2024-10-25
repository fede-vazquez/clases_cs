using Constructores.Models;

public class Program
{
    static void Main()
    {
        Empleado empleado1 = new Empleado();
        empleado1.MostrarDetalles();

        Empleado empleado2 = new Empleado("Juan Perez", "Ventas");
        empleado2.MostrarDetalles();

        Empleado empleado3 = new Empleado(empleado2);
        empleado2.MostrarDetalles();

        Empleado empleado4 = Empleado.CrearAdministrador("Juan");
        empleado4.MostrarDetalles();

        Console.WriteLine($"Total de empleados creados: {Empleado.TotalEmpleados}");
    }
}