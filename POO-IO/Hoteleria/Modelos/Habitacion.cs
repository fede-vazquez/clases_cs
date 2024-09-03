using Hoteleria.Enums;

namespace Hoteleria.Modelos
{
    public class Habitacion
    {
        public int Numero {  get; set; }
        public string Tipo { get; set; }
        public List<Servicio> Servicios { get; set; }

        public double TarifaBase { get; set; }

        public Habitacion(int numero, string tipo, double tarifa)
        {
            numero = Numero;
            Tipo = tipo;
            TarifaBase = tarifa;
            Servicios = new List<Servicio>();
        }

        public Habitacion(int numero, string tipo, double tarifa, List<Servicio> servicios)
        {
            numero = Numero;
            Tipo = tipo;
            TarifaBase = tarifa;
            Servicios = servicios;
        }

        public void AgregarServicio(Servicio servicio)
        {
            Servicios.Add(servicio);
        }

        public double CalcularTarifa(Temporada temporada)
        {
            // no va esto, ya que usando enums sabemos que va a llegar con un valor que queramos.
            //if (string.IsNullOrEmpty(temporada))
            //{
            //   throw new ArgumentNullException("Ingrese una temporada por favor!");
            //}

            // se puede hacer con ternario.
            if (temporada == Temporada.Alta)
            {
                return TarifaBase * 1.5;
            }
            return TarifaBase;
        }
    }
}
