using System;

namespace HospitalCentral.Modelos
{
    public class Hospital
    {
        public string Nombre { get; set; }
        public string Direccion {  get; set; }
        private List<Departamento> _departamentos;

        public Hospital(string nombre)
        {
            Nombre = nombre;
            _departamentos = new List<Departamento>();
        }

        public void AgregarDepa(Departamento depa)
        {
            _departamentos.Add(depa);
        }
        public void QuitarDepa(Departamento depa)
        {
            _departamentos.Remove(depa);
        }
    }
}
