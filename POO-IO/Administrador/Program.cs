// Se repiten en todas las clases el atributo Nombre y el método MostrarDetalle.

class Administrador
{
    // Hacer validacion para Nombre, como hicimos con Experiencia.
    public string Nombre { get; set; }
    public int Experiencia {
        get { return Experiencia; }
        set {
            if( value >= 0)
            {
                Experiencia = value;
            }
            else
            {
                throw new ArgumentException("La experiencia no debe ser negativa.");
            }
        }
    }

    public Administrador(string nombre, int experiencia)
    {
        Nombre = nombre;
        Experiencia = experiencia;
    }

    public void MostrarDetalle()
    {
        Console.WriteLine($"Nombre: {Nombre}, Experiencia: {Experiencia}");
    }
}

class Profesor
{
    public string Nombre { get; set; }
    public string Materia { get; set; }

    public Profesor(string nombre, string materia)
    {
        Nombre = nombre;
        Materia = materia;
    }

    public void MaterarDetalle()
    {
        Console.WriteLine($"Nombre {Nombre}, Materia: {Materia}");
    }
}

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void MaterarDetalle()
    {
        Console.WriteLine($"Nombre {Nombre}, Edad: {Edad}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Hola mundo");
    }
}