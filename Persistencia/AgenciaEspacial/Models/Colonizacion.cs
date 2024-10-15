using AgenciaEspacial.Enums;

namespace AgenciaEspacial.Models
{
    public class Colonizacion: Mision
    {
        public int Colonos {  get; private set; }
        public Colonizacion(string nombre, Destino destino, int astronautas, int colonos) : base(nombre, destino, astronautas)
        {
            Colonos = colonos;
        }
        public override double CalcularDuracion()
        {
            return Colonos * 2.5 + (int)DestinoMision * 3;
        }

        public override string ToString()
        {
            return $"{GetType().Name}, {Nombre}, {DestinoMision}, {Astronautas}, {Colonos}";
        }
    }
}