using ShoppingCine.Enums;

namespace ShoppingCine.Modelos
{
    public class Entrada
    {
        public Cine Cine { get; private set; }
        public Funcion Funcion { get; private set; }
        public Asiento Asiento { get; private set; }
        public double Precio
        {
            get
            {
                switch (Asiento.Tipo)
                {
                    case TipoAsiento.Superseat:
                        return Funcion.CostoFuncion * 1.2;
                    default: 
                        return Funcion.CostoFuncion;
                }
            }
        }
        public Entrada(Cine cine, Funcion funcion, Asiento asiento)
        {
            if (asiento.Ocupado == true) throw new Exception("El asiento seleccionado esta ocupado.");
            Cine = cine;
            Funcion = funcion;
            Asiento = asiento;
            Asiento.CambiarOcupado();
            
            MostrarDetalles();
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Gracias por comprar su entrada en {Cine.Nombre}.");
            Funcion.MostrarDetalles();
            Asiento.MostrarDetalles();
            Console.WriteLine($"Precio total: {Precio}\n");
        }
    }
} 