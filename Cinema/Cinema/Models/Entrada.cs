using Cinema.Enums;

namespace Cinema.Models
{
    public class Entrada
    {
        public Cine Cine { get; private set; }
        public Pelicula Pelicula { get; private set; }
        public Sala Sala { get; private set; }
        public Asiento Asiento { get; private set; }
        public DateTime Fecha { get; private set; }
        public double Precio
        {
            get
            {
                double precio = 100;
                if(Asiento.Tipo == TipoAsiento.Superseat)
                {
                    precio += precio * 0.15;
                }

                switch (Pelicula.Formato)
                {
                    case Formato._2D_Doblado:
                        precio += precio * 0.20;
                        break;
                    case Formato.IMAX_Doblado:
                        precio += precio * 0.40;
                        break;
                }
                return precio;
            }
        }

        public Entrada(Cine cine, Pelicula pelicula, Asiento asiento, DateTime fecha)
        {
            Cine = cine;
            Pelicula = pelicula;
            Asiento = asiento;
            Fecha = fecha;
        }

        public void MostrarDetalle()
        {

        }
    }
}
