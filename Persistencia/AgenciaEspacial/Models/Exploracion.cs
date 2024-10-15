using AgenciaEspacial.Enums;

namespace AgenciaEspacial.Models
{
    public class Exploracion : Mision
    {
        public Exploracion(string nombre, Destino destino, int astronautas) : base(nombre, destino, astronautas)
        {
        }
        public override double CalcularDuracion()
        {
            return Astronautas * 1.5 + (int)DestinoMision * 2;
        }

        public override string ToString()
        {
            return $"{GetType().Name}, {Nombre}, {DestinoMision}, {Astronautas}";
        }
    }
}
