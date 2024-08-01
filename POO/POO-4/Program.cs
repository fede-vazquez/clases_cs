// empleado tiempo medio y tiempo completo, atributos: nombre y salario, metodo: calcular salario()
// en el empleado de medio tiempo le avisamos que cobra la mitad del salario.
// el mensaje será "Saladio de {Nombre}: {calcularSalario}". Es decir, construimos el WriteLine dentro del Main.

abstract class Persona
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }
}
abstract class Empleado : Persona
{
    public int Salario { get; set; }

    public Empleado(string nombre, int salario) : base(nombre)
    {
        Salario = salario;
    }

    public abstract float CalcularSalario();
}

class EmpleadoMedioTiempo : Empleado
{
    public EmpleadoMedioTiempo(string nombre, int salario) : base(nombre, salario) { }

    public override float CalcularSalario()
    {
        return (Salario / 2);
    }
}

class EmpleadoTiempoCompleto : Empleado
{
    public EmpleadoTiempoCompleto(string nombre, int salario) : base(nombre, salario) { }

    public override float CalcularSalario()
    {
        return Salario;
    }
}

class Program
{
    static void Main()
    {
        Empleado empleadoMedioTiempo = new EmpleadoMedioTiempo("Paquito", 400000);
        Console.WriteLine($"El empleado {empleadoMedioTiempo.Nombre} tiene un salario de ${empleadoMedioTiempo.CalcularSalario()}.");

        Empleado empleadoTiempoCompleto = new EmpleadoTiempoCompleto("Jorgito", 400000);
        Console.WriteLine($"El empleado {empleadoTiempoCompleto.Nombre} tiene un salario de ${empleadoTiempoCompleto.CalcularSalario()}");
    }
}