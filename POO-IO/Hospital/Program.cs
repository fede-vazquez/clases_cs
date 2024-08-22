using HospitalCentral.Modelos;

namespace HospitalCentral
{
    class Program
    {
        static void Main()
        {
            Especializacion especializacion = new Especializacion("Cardiología");

            Hospital hospital = new Hospital("Hospital Central", "Calle falsa 123");

            Departamento cardiologia = new Departamento("Cardiología");

            Medico medico = new Medico("Dr. House", especializacion);

            Paciente paciente = new Paciente("Juan Perez", 30);

            Procedimiento procedimiento = new Procedimiento("Cirugìa de corazón");

            EquipoMedico equipoMedico = new EquipoMedico("Equipo de cirugía", "Cirugía");

            SalaDeOperaciones sala = new SalaDeOperaciones(1);


            hospital.AgregarDepa(cardiologia);
            
            cardiologia.AgregarMedico(medico);

            medico.AtenderPaciente(paciente);

            cardiologia.AgregarProcedimiento(procedimiento);

            procedimiento.AsignarSala(sala);
        }
    }
}