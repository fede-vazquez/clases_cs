// Asociación.
/*
 En la empresa "TecSolutions" cada empleado tiene una targeta de identificación personal que contiene su nombre, apellido,
número de identificación y fecha de emición. La empresa necesita implementar un sistema que gestione a los empleados
y sus tarjetas de identificación.
*/
class TarjetaIdentificacion
{

    static int tarjetas = 0;
    // private set: hace que el seteo sea privado y el get sea publico.
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public int NumeroIdentifiacion { get; private set; }
    // Estas variables pueden tener un valor designado colocando = valor
    public DateTime FechaEmision { get; private set; } = DateTime.Now;

    public TarjetaIdentificacion(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
        NumeroIdentifiacion = ++tarjetas; //++variable pre-incremento. Suma la variable y despues la devuelve. Ejemplo 0 + 1
    }

    public void MostrarDetalles()
    {
        Console.WriteLine(
            $"Tarjeta identificación: {Nombre} {Apellido}, " +
            $"ID: {NumeroIdentifiacion}, " +
            $"Emitida el: {FechaEmision.ToShortDateString()}"
            );
    }
}

class Empleado
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public TarjetaIdentificacion Tarjeta { get; private set; }

    public Empleado(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
        Tarjeta = new TarjetaIdentificacion(Nombre, Apellido);
    }

    public void MostrarDetallesEmpleado()
    {
        Console.WriteLine($"Empleado: {Nombre} {Apellido}");
        // No podemos llamar simplemente a MostrarDetalles, ya que no es una herencia.
        Tarjeta.MostrarDetalles();
    }
}
class Program
{
    static void Main()
    {
        // TarjetaIdentificacion tarjeta = new TarjetaIdentificacion("Carlos", "Santana", 123);
        // tarjeta.MostrarDetalles();

        Empleado empleado = new Empleado("Carlos", "Santana");
        empleado.MostrarDetallesEmpleado();

        Empleado empleado2 = new Empleado("Juan", "Perez");
        empleado2.MostrarDetallesEmpleado();
    }
}