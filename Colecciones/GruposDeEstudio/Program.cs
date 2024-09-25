// lista de grupos y listar todos los estudiantes de todos los grupos (si es posible que los separe por grupos)
using GruposDeEstudio.Models;
class Program
{
    static void Main()
    {

        int opcion;

        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("==== Menú ===");
            Console.WriteLine("1. Crear nuevo grupo de estudio.");
            Console.WriteLine("2. Añadir estudiante a un grupo con su lista de materias.");
            Console.WriteLine("3. Mostrar estudiantes de un grupo por su materia.");
            Console.WriteLine("4. Salir.");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (opcion)
            {
                case 1:
                    SistemaGrupos.CrearGrupo();
                    break;

                case 2:
                    SistemaGrupos.AgregarEstudiante();
                    break;

                case 3:
                    SistemaGrupos.MostrarEstudiantesPorMateria();
                    break;
                case 4:
                    Console.WriteLine("Saliendo");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta.");
                    break;
            }

        } while (opcion != 4);

    }
}