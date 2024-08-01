// empleado tiempo medio y tiempo completo, atributos: nombre y salario, metodo: calcular salario()
// en el empleado de medio tiempo le avisamos que cobra la mitad del salario.
// el mensaje será "Saladio de {Nombre}: {calcularSalario}". Es decir, construimos el WriteLine dentro del Main.

abstract class Empleado
{
    public string Nombre { get; set; }
    public int Salario { get; set; }

    public Empleado(string nombre, int salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public abstract void CalcularSalario();
}