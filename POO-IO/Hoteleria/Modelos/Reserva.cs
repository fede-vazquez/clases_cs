using Hoteleria.Enums;

namespace Hoteleria.Modelos
{
    public class Reserva
    {
        private static int Reservas = 0;
        public Hotel Hotel { get; set; }
        public List<Habitacion> Habitaciones { get; set; } = new List<Habitacion>();
        public int Numero {  get; private set; }
        public DateTime FechaReserva { get; set; }
        public string MetodoPago { get; set; }

        public Reserva(Hotel hotel, Habitacion habitacion, DateTime fechaReserva, string metodoPago)
        {
            Hotel = hotel;
            Numero = ++Reservas;
            Habitaciones.Add(habitacion);
            FechaReserva = fechaReserva;
            MetodoPago = metodoPago;
        }
        public Reserva(Hotel hotel, List<Habitacion> habitaciones, DateTime fechaReserva, string metodoPago)
        {
            if(habitaciones.Count <= 0)
            {
                throw new ArgumentException("La lista de habitaciones no debe ser vacía.");
            }
            Hotel = hotel;
            // si estuvieramos trabajando con bases de datos, automaticamente va a aumentarse, para evitar que dos registros tengan el mismo id/numero.
            Numero = ++Reservas;
            Habitaciones = habitaciones;
            FechaReserva = fechaReserva;
            MetodoPago = metodoPago;
        }

        public double CalcularCostoServicios()
        {
            double costoServicios = 0;

            foreach (var habitacion in Habitaciones)
            {
                foreach (var servicio in habitacion.Servicios)
                {
                    costoServicios += servicio.Costo;
                }
            }
            return costoServicios;
        }

        public double CalcularCostoTotal(Temporada temporada)
        {
            double totalTarifasHabitacion = 0;
            foreach (var habitacion in Habitaciones)
            {
                totalTarifasHabitacion += habitacion.CalcularTarifa(temporada);
            }
            return totalTarifasHabitacion + CalcularCostoServicios();
        }
    }
}
// tarea para mañana: refactorizar estos 2 métodos.