namespace NotasAlumnos.Models
{
    public class ListaAlumnos
    {
        public List<Alumno> Alumnos {  get; private set; } = new List<Alumno>();

        public void AgregarEstudiante(Alumno alumno)
        {
            if (!Alumnos.Contains(alumno)) Alumnos.Add(alumno);
        }
    }
}
