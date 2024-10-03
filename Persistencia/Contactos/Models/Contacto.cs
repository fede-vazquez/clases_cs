namespace Contactos.Models
{
    public class Contacto
    {
        public string Nombre { get; private set; }
        public int Telefono { get; private set; }
        public string CorreoElectronico { get; private set; }

        public Contacto(string nombre, int telefono, string correoElectronico)
        {
            Nombre = nombre;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
        }

        // Olvidé que podía sobreescribir el método ToString para que muestre la info.
        public override string ToString()
        {
            return $"{Nombre} - {Telefono} - {CorreoElectronico}";
        }
    }
}