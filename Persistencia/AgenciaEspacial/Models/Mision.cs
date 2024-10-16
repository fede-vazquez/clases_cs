using AgenciaEspacial.Enums;

namespace AgenciaEspacial.Models
{
    public abstract class Mision
    {
        public string Nombre { get; private set; }
        public Destino DestinoMision { get; private set; }
        public int Astronautas { get; private set; }

        public Mision(string nombre, Destino destino, int astronautas)
        {
            Nombre = nombre;
            DestinoMision = destino;
            Astronautas = astronautas;
        }

        public abstract double CalcularDuracion(); // Duración en meses

        public abstract override string ToString();
    }
}