using ShoppingCine.Enums;

namespace ShoppingCine.Modelos
{
    public class Funcion
    {
        public Sala Sala { get; private set; }
        public Pelicula Pelicula { get; private set; }
        public TimeOnly Horario { get; private set; }
        public DateTime Fecha { get; private set; }
        public double CostoFuncion
        {
            get
            {
                double costoSala = Sala.CostoBase;
                switch (Pelicula.Formato)
                {
                    case Formato._3D_Doblada or Formato._3D_Subtitulada:
                        return costoSala * 1.2;
                    case Formato._IMAX_Subtitulada or Formato._IMAX_Doblada:
                        return costoSala * 1.4;
                    default:
                        return costoSala;
                }
            }
        }

        public Funcion(Sala sala, Pelicula pelicula, DateTime fecha, TimeOnly horario)
        {
            Sala = sala;
            Pelicula = pelicula;
            Fecha = fecha;
            Horario = horario;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Pelicula: {Pelicula.Nombre}, Sala: {Sala.Numero}");
            Console.WriteLine($"Formato: {Pelicula.Formato}");
            Console.WriteLine($"Fecha: {Fecha}, Horario: {Horario}");
        }
        public void DefinirHorario(TimeOnly hora) => Horario = hora;
        public void ReproducirPelicula() => Pelicula.Reproducir();
    }
}