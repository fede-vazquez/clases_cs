using  Clima.Modelos;

namespace Clima.Modelos
{
    class Program
    {
        static void Main()
        {
            Clima unClima = new Clima(11, "Nublado");

            Ubicacion unaUbicacion = new Ubicacion("San Nicho", "Argentina", unClima);

            Meteorologo meteorologo1 = new Meteorologo("Pepito", "Agricola");
            Meteorologo meteorologo2 = new Meteorologo("Jorgito", "Normal");

            Estacion estacion1 = new Estacion(unaUbicacion, meteorologo1);
            Estacion estacion2 = new Estacion(unaUbicacion, meteorologo2);

            RedClimatica unaRedClimatica = new RedClimatica("Juancito", new List<Estacion> { estacion1, estacion2 });

            unaRedClimatica.MostrarDetalle();
        }
    }
}