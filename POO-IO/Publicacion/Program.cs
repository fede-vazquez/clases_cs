class Publicacion
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Publicacion(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"\nTitulo: {Titulo} \nAutor: {Autor}");
    }
}

class Libro : Publicacion
{
    public string Genero { get; set; }

    public int NumeroPaginas { get; set; }

    public Libro(string titulo, string genero, string autor, int numeroPaginas) : base(titulo, autor)
    {
        Genero = genero;
        NumeroPaginas = numeroPaginas;
    }

    public void MostrarInformacionLibro()
    {
        MostrarInformacion();
        Console.WriteLine($"Genero: {Genero} \nNumero de páginas: {NumeroPaginas}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el titulo del libro: ");
        string titulo = Console.ReadLine() ?? "";

        Console.Write("Ingrese el genero del libro: ");
        string genero = Console.ReadLine() ?? "";

        Console.Write("Ingrese el autor del libro: ");
        string autor = Console.ReadLine() ?? "";

        Console.Write("Ingrese el numero del libro: ");
        int numeroPaginas;
        int.TryParse(Console.ReadLine(), out numeroPaginas);

        Libro unLibro = new Libro(titulo, genero, autor, numeroPaginas);
        Console.WriteLine("\nInformación del libro:");

        unLibro.MostrarInformacionLibro();
    }
}