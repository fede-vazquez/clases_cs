class Persona
{
    private string _nombre = "Nombre default";
    private int _edad;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public int Edad
    {
        get { return _edad; }
        set { _edad = value; }
    }
}

class Program
{
    static void Main()
    {
        // Forma de utilizar directamente los setters. usar llaves en lugar de parentesis, y dentro poner los atributos de la clase y sus datos.
        Persona persona = new Persona
        {
            Nombre = "Jorguito",
            Edad = 23
        };
        
        //persona.Nombre = "Jorguito";
        //persona.Edad = 23;

        Console.WriteLine($"Nombre: {persona.Nombre}");
        Console.WriteLine($"Edad: {persona.Edad}");
    }
}