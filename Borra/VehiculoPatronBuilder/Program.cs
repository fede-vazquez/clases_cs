using VehiculoPatronBuilder.Models;

namespace VehiculoBuilder
{
    public class Program
    {
        static void Main()
        {
            VehiculoDirector director = new VehiculoDirector(new CocheBuilder());
            Vehiculo coche = director.Construir();
            Console.WriteLine(coche);

            director = new VehiculoDirector(new CamionBuilder());
            Vehiculo camion = director.Construir();
            Console.WriteLine(camion);
        }
    }
}

// hacer builder de reportes, de texto y de pdf