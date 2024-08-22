using System;

namespace Clima.Modelos
{
    public class Clima
    {
        public decimal TemperaturaC { get; set; }
        public string Condicion { get; set; }

        public Clima(decimal temperaturaC, string condicion)
        {
            TemperaturaC = temperaturaC;
            Condicion = condicion;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Temperatura: {TemperaturaC}°\n");
        }
    }
}
