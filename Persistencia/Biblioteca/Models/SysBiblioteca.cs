namespace Biblioteca.Models
{
    public static class SysBiblioteca
    {
        static List<Libro> Libros = new();
        static List<Usuario> Usuarios = new();
        static readonly string ArchivoUsuario = "Usuario.txt";
        static readonly string ArchivoLibros = "Libros.txt";

        public static void AgregarLibro(Libro libro) => Libros.Add(libro);
        public static void AgregarLibro(Usuario usuario) => Usuarios.Add(usuario);

        public static void RealizarPrestamo(Libro libro, Usuario usuario)
        {
            if(libro.EjemplaresDisponibles >= 1)
            {
                Prestamo prestamito = new Prestamo(libro, DateTime.Now);
                libro.QuitarEjemplar();
                usuario.AgregarPrestamo(prestamito);
                Console.WriteLine("Prestamo realizado con éxito");
            }
            else
            {
                Console.WriteLine("La cantidad de ejemplares disponibles no es suficíente.");
            }
        }

        public static void DevolverLibro(Libro libro, Usuario usuario)
        {
            Prestamo prestamo = usuario.Prestamos.Find((p) => p.Libro == libro);

            if(prestamo != null)
            {
                usuario.QuitarPrestamo(prestamo);
                libro.AgregarEjemplar();
            }
            else
            {
                Console.WriteLine($"El usuario {usuario.Nombre} no realizó el prestamo del libro {libro.Titulo}");
            }
        }

        public static void CargarLibro(Libro libro)
        {
            
        }
    }
}