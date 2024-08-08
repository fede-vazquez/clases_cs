class Libro
{
public string Titulo { get; set; }
public string Autor { get; set; }
public string Genero { get; set; }
public int NumeroPaginas { get; set; }

public Libro(string titulo, string autor, string genero, int numeroPaginas)
{
    Titulo = titulo;
    Autor = autor;
    Genero = genero;
    NumeroPaginas = numeroPaginas;
}

public void MostrarLibro()
{
/*    Console.WriteLine(Titulo);
    Console.WriteLine($"\nGenero: {Genero}");
    Console.WriteLine($"\nNumero de páginas: {NumeroPaginas}");
    Console.WriteLine($"\nAutor: {Autor}");*/

    Console.WriteLine(
        $"\nTitulo: . . . . . . . . {Titulo}" +
        $"\nGenero: . . . . . . . . {Genero}" +
        $"\nAutor:  . . . . . . . . {Autor}" +
        $"\nNumero de páginas:. . . {NumeroPaginas}"
        );
    }
}

class Program
{
    static void Main()
    {
        string titulo, genero, autor;
        int numeroPaginas;

        Console.Write("Ingrese el título del libro: ");
        titulo = Console.ReadLine();

        Console.Write("Ingrese el genero del libro: ");
        genero = Console.ReadLine();

        Console.Write("Ingrese el autor del libro: ");
        autor = Console.ReadLine();

        Console.Write("Ingrese el número de páginas: ");
        int.TryParse(Console.ReadLine(), out numeroPaginas);

        if (titulo == "" || autor == "" || genero == "" || numeroPaginas <= 0)
        {
            Console.WriteLine("Uno de los parametros pasados es incorrecto, compruebe que haya agregado el titulo, autor, genero y que el número de páginas sea mayor a 0.");
        }
        else
        {
            Libro libro = new Libro(titulo, autor, genero, numeroPaginas);
            libro.MostrarLibro();
        }
    }
}