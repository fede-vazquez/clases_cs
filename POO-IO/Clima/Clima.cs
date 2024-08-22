using System;

namespace Clima
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
    }
}