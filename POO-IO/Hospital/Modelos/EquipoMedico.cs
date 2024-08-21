using System;

namespace Hospital.Modelos
{
    public class EquipoMedico
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public EquipoMedico(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }
        
        public void AgregarAProcedimineto(Procedimiento proc)
        {
            // con el this le digo que le agrege este mismo equipo Medico.
            proc.AgregarEquipoMedico(this);
        }
    }
}
