// Se repiten en todas las clases el atributo Nombre y el método MostrarDetalle.
// Las validaciones me dan un loop infinito.

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

class Materia
{
    public string Nombre { get; set; }
    
    public Materia(string nombre)
    {
        Nombre = nombre;
    }

    public void MostrarDetalle()
    {
        Console.WriteLine($"Nombre materia: {Nombre}");
    }
}

class Profesor
{
    public string Nombre { get; set; }
    public List<Materia> Materias { get; set; } = new List<Materia>();

    public Profesor(string nombre, Materia materia)
    {
        Nombre = nombre;
        Materias.Add(materia);
    }

    // Falta mostrar las materias en lista.
    public void MostrarDetalle()
    {
        Console.WriteLine($"Nombre {Nombre}, Materias: {Materias}");
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

    public void MostrarDetalle()
    {
        Console.WriteLine($"Nombre {Nombre}, Edad: {Edad}");
    }
}

class Escuela
{
    public string Nombre { get; set; }
    
    // Esto no entiendo como hacerlo
    public Administrador Administrador { get; set; } = null;

    public List<Profesor> Profesores { get; set; }

    public Escuela(string nombre)
    {
        Nombre = nombre;
        Profesores = new List<Profesor>();
    }

    public void AgregarProfesor(Profesor nuevoProfesor)
    {
        Profesores.Add(nuevoProfesor);
    }

    public void MostrarDetalle()
    {
        Console.WriteLine($"Nombre: {Nombre}, Administrador: {Administrador}");
    }
}

class Aula
{
    public string Nombre { get; set; }

    // Tampoco sé que hacer aca.
    public Profesor ProfesorAula { get; set; }

    public Aula(string nombre)
    {
        Nombre = nombre;
    }

    public void MostrarDetalle()
    {
        Console.WriteLine($"Nombre: {Nombre}, Profesor del aula: {ProfesorAula.Nombre}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Hola mundo");
    }
}