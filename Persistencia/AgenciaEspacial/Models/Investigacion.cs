﻿using AgenciaEspacial.Enums;

namespace AgenciaEspacial.Models
{
    public class Investigacion : Mision
    {
        public string CampoInvestigacion { get; private set; }
        public Investigacion(string nombre, Destino destino, int astronautas, string campoInvestigacion) : base(nombre, destino, astronautas)
        {
            CampoInvestigacion = campoInvestigacion;
        }
        public override double CalcularDuracion()
        {
            return Astronautas * 2 + (int)DestinoMision * 1.5;
        }

        public override string ToString()
        {
            return $"{GetType().Name}, {Nombre}, {DestinoMision}, {Astronautas}, {CampoInvestigacion}";
        }
    }
}