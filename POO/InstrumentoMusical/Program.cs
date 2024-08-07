class InstrumentoMusical
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }

    public InstrumentoMusical(string nombre, string tipo)
    {
        Nombre = nombre;
        Tipo = tipo;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"\nNombre: {Nombre}, Tipo: {Tipo}.");
    }
}

class InstrumentoMusicalDeCuerda : InstrumentoMusical
{
    public int NumeroDeCuerdas { get; set; }

    public InstrumentoMusicalDeCuerda(string nombre, string tipo, int numeroDeCuerda) : base(nombre, tipo)
    {
        NumeroDeCuerdas = numeroDeCuerda;
    }

    public void MostrarInformacionCuerda()
    {
        MostrarInformacion();
        Console.WriteLine($"Numero cuerdas: {NumeroDeCuerdas}.");
    }
}

class InstrumentoMusicalDeViendo : InstrumentoMusical
{
    public string Material { get; set; }

    public InstrumentoMusicalDeViendo(string nombre, string tipo, string material) : base(nombre, tipo)
    {
        Material = material;
    }

    public void MostrarInformacionViento()
    {
        MostrarInformacion();
        Console.WriteLine($"Material: {Material}");
    }
}

class Guitarra : InstrumentoMusicalDeCuerda
{
    public Guitarra(string nombre, string tipo, int numeroDeCuerda) : base(nombre, tipo, numeroDeCuerda) { }

    public void MostrarInformacionGuitarra()
    {
        MostrarInformacionCuerda();
    }
}
class Piano : InstrumentoMusicalDeCuerda
{
    public int NumeroDeTeclas { get; set; }
    public Piano(string nombre, string tipo, int numeroDeCuerda, int numeroDeTeclas) : base(nombre, tipo, numeroDeCuerda)
    {
        NumeroDeTeclas = numeroDeTeclas;
    }


    public void MostrarInformacionPiano()
    {
        MostrarInformacionCuerda();
        Console.WriteLine($"Numero de teclas: {NumeroDeTeclas}");
    }
}

class Flauta : InstrumentoMusicalDeViendo
{
    public Flauta(string nombre, string tipo, string material) : base(nombre, tipo, material) { }

    public void MostrarInformacionFlauta() => MostrarInformacionViento(); // forma de ahorrar un poco de codigo.
}

// tarea: hacer clase con instrumentos de percusion.

class Program
{
    static void Main()
    {
        Guitarra guitarra = new Guitarra("Guitarra acústica", "cuerda", 6);
        guitarra.MostrarInformacionGuitarra();

        Flauta flauta = new Flauta("Flauta dulce", "Viento", "Madera");
        flauta.MostrarInformacionFlauta();

        Piano piano = new Piano("Piano de cola", "cuerda", 230, 88);
        piano.MostrarInformacion();
        piano.MostrarInformacionCuerda();
        piano.MostrarInformacionPiano();
    }
}