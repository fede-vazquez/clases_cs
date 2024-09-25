namespace GruposDeEstudio.Models
{
    public static class SistemaGrupos
    {
        static Dictionary<string, GrupoEstudio> grupos = new Dictionary<string, GrupoEstudio>();
        public static void CrearGrupo()
        {
            Console.Write("Ingrese el nombre del grupo: ");
            string nombreGrupo = Console.ReadLine();

            grupos[nombreGrupo]= new GrupoEstudio(nombreGrupo);
            Console.WriteLine($"Grupo de estudio '{nombreGrupo}' creado.");
        }

        public static void AgregarEstudiante()
        {
            Console.Write("Ingrese el nombre del grupo al que quiere agregar el estudiante: ");
            string nombreGrupo = Console.ReadLine();

            if (grupos.ContainsKey(nombreGrupo)){
                Console.Write("Ingrese el nombre del estudiante: ");
                string nombreEstudiante = Console.ReadLine();

                Console.Write("Ingrese las materias del estudiante, separadas por coma: ");
                string materiasInput = Console.ReadLine();
                List<string> materias = new List<string>(materiasInput.Split(","));

                Estudiante estudiante = new Estudiante(nombreEstudiante, materias);
                grupos[nombreGrupo].AgregarEstudiante(estudiante);

                Console.WriteLine($"Estudiante {nombreEstudiante} agregado al grupo {nombreGrupo}.");
            }
            else
            {
                Console.WriteLine("El grupo no existe.");
            }
        }

        public static void MostrarEstudiantesPorMateria()
        {
            Console.Write("Ingrese el nombre del grupo: ");
            string nombreGrupo = Console.ReadLine();

            if (grupos.ContainsKey(nombreGrupo))
            {
                Console.Write("Ingrese la materia para filtrar: ");
                string materia = Console.ReadLine();

                grupos[nombreGrupo].MostrarEstudiantesPorMateria(materia);
            }
            else
            {
                Console.WriteLine("El grupo no existe");
            }
        }
    }
}
