using ShoppingCine.Enums;

namespace ShoppingCine.Modelos
{
    public class Entrada
    {
        public Cine Cine { get; private set; }
        public Sala Sala { get; private set; }
        public Asiento Asiento { get; private set; }
        public double Precio
        {
            get
            {
                switch (Asiento.Tipo)
                {
                    case TipoAsiento.Superseat:
                        return Sala.Costo * 1.2;
                    default: 
                        return Sala.Costo;
                }
            }
        }
        public DateTime Fecha { get; private set; }

        public Entrada(Cine cine, Sala sala, Asiento asiento, DateTime fecha)
        {
            Cine = cine;
            Sala = sala;
            Fecha = fecha;
            Asiento = asiento;
            
            // Asumiendo que el asiento estará libre en este punto.
            Asiento.CambiarOcupado();
            
            MostrarDetalles();
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Gracias por comprar su entrada en {Cine.Nombre}.");
            Console.WriteLine($"Pelicula: {Sala.Pelicula.Nombre}, Sala: {Sala.Numero}");
            Console.WriteLine($"Formato: {Sala.Pelicula.Formato}");
            Console.WriteLine($"Fecha: {Fecha}, Horario: {Sala.Horario}");
            Console.WriteLine($"Asiento: {Asiento.Letra}{Asiento.Numero}, tipo de asiento: {Asiento.Tipo}");
            Console.WriteLine($"Precio total: {Precio}\n");
        }
    }
}