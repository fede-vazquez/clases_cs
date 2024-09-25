namespace GruposDeEstudio.Models
{
    public class GrupoEstudio
    {
        public string NombreGrupo { get; private set; }
        public List<Estudiante> Estudiantes { get; private set; } = new List<Estudiante>();

        public GrupoEstudio(string nombreGrupo) => NombreGrupo = nombreGrupo;

        public void AgregarEstudiante(Estudiante estudiante)
        {
            if (!Estudiantes.Contains(estudiante))
            {
                Estudiantes.Add(estudiante);
            }
            else
            {
                Console.WriteLine("El estudiante ya forma parte del grupo.");
            }
        }

        // Este método es mas simple del que yo hice abajo.
        public void MostrarEstudiantesPorMateria(string materia)
        {
            Console.WriteLine($"Estudiantes en el grupo {NombreGrupo} que están inscriptos en {materia}");
            foreach (var est in Estudiantes)
            {
                if (est.Materias.Contains(materia))
                {
                    Console.WriteLine($"- {est.Nombre}");
                }
            }
        }

        public void BuscarPorMateria(string materia)
        {
            List<Estudiante> estudiantesPorMateria = Estudiantes.FindAll((estudiante) => estudiante.Materias.Contains(materia));

            if(estudiantesPorMateria.Count > 0)
            {
                foreach (var estudiante in estudiantesPorMateria)
                {
                    Console.WriteLine($"{estudiante.Nombre}");
                }
            }
        }
    }
}
