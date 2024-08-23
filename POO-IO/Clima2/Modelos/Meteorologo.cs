using System;
using System.Net.WebSockets;

namespace Clima.Modelos
{
    public class Meteorologo
    {
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        public Meteorologo(string nombre, string especialidad)
        {
            Nombre = nombre;
            Especialidad = especialidad;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"Meteorologo: {Nombre}, Especialidad: {Especialidad}");
        }
    }
}
