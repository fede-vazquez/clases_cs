using System;

namespace Clima.Modelos
{
    public class Ubicacion
    {
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public Clima Clima { get; set; }
        
        public Ubicacion(string ciudad, string pais, Clima clima)
        {
            Ciudad = ciudad;
            Pais = pais;
            Clima = clima;
        }
    }
}
