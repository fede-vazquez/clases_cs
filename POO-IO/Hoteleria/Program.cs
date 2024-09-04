using Hoteleria.Modelos;
using Hoteleria.Enums;
public class Program
{
    static void Main()
    {
        Hotel hotel = new Hotel("Gran Hotel", Temporada.Alta);

        Habitacion habitacion1 = new Habitacion(1, "suite", 500);
        Habitacion habitacion2 = new Habitacion(1, "estandar", 300);

        Servicio serv1 = new Servicio("Limpieza", 60);
        Servicio serv2 = new Servicio("Lavandería", 80);

        hotel.AgregarHabitacion(habitacion1);
        hotel.AgregarHabitacion(habitacion2);

        habitacion1.AgregarServicio(serv1);
        habitacion1.AgregarServicio(serv2);
        
        habitacion2.AgregarServicio(serv1);

        List<Habitacion> habitaciones = new List<Habitacion>();
        habitaciones.Add(habitacion1);
        habitaciones.Add(habitacion2);

        Reserva reserva1 = new Reserva(hotel, habitacion1, DateTime.Now, "efectivo");
        Reserva reserva2 = new Reserva(hotel, habitaciones, DateTime.Now, "efectivo");

        //Console.WriteLine($"Costo servicios de la reserva 1: {reserva1.CalcularCostoServicios()}\n");
        //Console.WriteLine($"Costo servicios de la reserva 2: {reserva2.CalcularCostoServicios()}\n");
        //Console.WriteLine($"Costo total de reserva 1: {reserva1.CalcularCostoTotal(Temporada.Baja)}\n");
        //Console.WriteLine($"Costo total de reserva 2: {reserva2.CalcularCostoTotal(Temporada.Alta)}\n");
    }

}