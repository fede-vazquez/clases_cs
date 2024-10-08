namespace Biblioteca.Models
{
    public class LibroUsuario
    {
        public Usuario Usuario { get; private set; }
        public Libro Libro { get; private set; }

        public LibroUsuario(Usuario usuario, Libro libro)
        {
            Usuario = usuario;
            Libro = libro;
        }
    }
}
