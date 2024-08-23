using System;

namespace Clima.Modelos
{
    public class Estacion
    {
        public Ubicacion Ubicacion { get; set; }
        public Meteorologo Meteorologo { get; set; }

        public Estacion(Ubicacion ubicacion, Meteorologo meteorologo)
        {
            Ubicacion = ubicacion;
            Meteorologo = meteorologo;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine("\nDetalles de la estación:");
            Ubicacion.MostrarDetalle();
            Meteorologo.MostrarDetalle();
        }
    }
}