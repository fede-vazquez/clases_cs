namespace Biblioteca.Models
{
    public class Libro
    {
        public string Codigo { get; private set; }
        public string Titulo { get; private set; }
        public string Autor {  get; private set; }
        public int EjemplaresDisponibles { get; private set; }

        public Libro(string codigo, string titulo, string autor, int ejemplaresDisponibles)
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            EjemplaresDisponibles = ejemplaresDisponibles;
        }

        public void AgregarEjemplar() => EjemplaresDisponibles++;
        public void QuitarEjemplar() => EjemplaresDisponibles--;
    }
}
