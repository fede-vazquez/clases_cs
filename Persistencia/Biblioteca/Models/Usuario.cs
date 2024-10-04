namespace Biblioteca.Models
{
    public class Usuario
    {
        public string Nombre { get; private set; }
        public List<Prestamo> Prestamos { get; private set; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarPrestamo(Prestamo prestamo) => Prestamos.Add(prestamo);
        public void QuitarPrestamo(Prestamo prestamo) => Prestamos.Remove(prestamo);
    }
}
