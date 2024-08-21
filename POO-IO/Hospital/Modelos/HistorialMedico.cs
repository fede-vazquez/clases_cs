using System;

namespace HospitalCentral.Modelos
{
    public class HistorialMedico
    {
        public string Diagnosticos { get; set; }
        public string Tratamientos { get; set; }

        public void AgregarDiagnostico(string diagnosticos)
        {
            Diagnosticos += diagnosticos + "\n";
        }
        public void AgregarTratamiento(string tratamientos)
        {
            Tratamientos += tratamientos + "\n";
        }
    }
}