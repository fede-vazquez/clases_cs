using Biblioteca.Models;

namespace Biblioteca.Models
{
    public static class Menu
    {
        public static void ArmarPedirLibro()
        {
            Console.Write("Ingrese el código del libro: ");
            string cod = Console.ReadLine();

            Console.Write("Ingrese el titulo del libro: ");
            string tit = Console.ReadLine();

            Console.Write("Ingrese el autor del libro: ");
            string aut = Console.ReadLine();

            Console.Write("Ingrese la cantidad de ejemplares del libro: ");
            int cantE = int.Parse(Console.ReadLine());

            Libro lib = new Libro(cod, tit, aut, cantE);
            SysBiblioteca.AgregarLibro(lib);

            Console.WriteLine("Libro agregado!");
        }
        public static void ArmarPedirUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombre = Console.ReadLine();

            Usuario usu = new Usuario(nombre);
            SysBiblioteca.AgregarUsuario(usu);

            Console.WriteLine("Usuario agregado!");
        }
        public static void ArmarPedirPrestamo()
        {
            try
            {
                var libroYUsuario = ArmarLibroYUsuario();
                SysBiblioteca.RealizarPrestamo(libroYUsuario.Libro, libroYUsuario.Usuario);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }
        }
        public static void ArmarPedirDevolucion()
        {
            try
            {
                var libroYUsuario = ArmarLibroYUsuario();
                SysBiblioteca.RealizarDevolucion(libroYUsuario.Libro, libroYUsuario.Usuario);
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }
        }

        public static (Libro, Usuario) ArmarPedirUsuarioYLibro()
        {
            Libro lib = new Libro("q", "f", "a", 12);
            Usuario usu = new Usuario("q");

            return (lib, usu);
        }

        public static LibroUsuario ArmarLibroYUsuario()
        {
            Console.Write("Ingrese el codigo del libro: ");
            string cod = Console.ReadLine();
            var libros = SysBiblioteca.ObtenerLibros();
            var libro = libros.Find((l) => l.Codigo == cod);

            if (libro == null)
            {
                throw new ArgumentException("Libro no encontrado!");
            }

            Console.Write("Ingrese el nombre del usuario: ");
            string nom = Console.ReadLine();
            var usuarios = SysBiblioteca.ObtenerUsuarios();
            var usu = usuarios.Find((l) => l.Nombre == nom);

            if (usu == null)
            {
                throw new ArgumentException("Usuario no encontrado!");
            }

            return new LibroUsuario(usu, libro);
        }
    }
}

/*
 * Console.Write("Ingrese el codigo del libro: ");
string cod = Console.ReadLine();
var libros = SysBiblioteca.ObtenerLibros();
var libro = libros.Find((l) => l.Codigo == cod);

if (libro == null)
{
    Console.WriteLine("Libro no encontrado!");
    return;
}

Console.Write("Ingrese el nombre del usuario: ");
string nom = Console.ReadLine();
var usuarios = SysBiblioteca.ObtenerUsuarios();
var usu = usuarios.Find((l) => l.Nombre == nom);

if (usu == null)
{
    Console.WriteLine("Usuario no encontrado!");
    return;
}

SysBiblioteca.DevolverLibro(libro, usu);
*/