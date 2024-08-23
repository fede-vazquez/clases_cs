using System;

namespace Clima.Modelos
{
    public class RedClimatica
    {
        public string Jefe { get; set; }
        private List<Estacion> _estaciones = new List<Estacion>(2);

        public RedClimatica(string jefe, List<Estacion> estaciones)
        {
            Jefe = jefe;
            if(estaciones.Count < 2)
            {
                throw new Exception("Se necesitan al menos 2 estaciones.");
            }
            _estaciones = estaciones;
        }

        public void AgregarEstacion(Estacion estacion)
        {
            _estaciones.Add(estacion);
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"Jefe de la red: {Jefe}\n");
            foreach (var estacion in _estaciones)
            {
                estacion.MostrarDetalle();
            }
        }
    }
}
