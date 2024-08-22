using System;

namespace HospitalCentral.Modelos
{
    public class Hospital
    {
        public string Nombre { get; set; }
        public string Direccion {  get; set; }
        private List<Departamento> _departamentos;

        public Hospital(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
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
        // fuera del diagrama
        public List<Departamento> ObtenerDepartamentos() => _departamentos;
    }
}
