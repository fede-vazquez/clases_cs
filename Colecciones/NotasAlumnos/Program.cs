// El ejercicio real era solo una calificación por alumno, es decir que cada profesor tiene alumnos y cada alumno tiene calificacion.
// No se puede hacer como lo estoy haciendo ya que no tengo un identificador unico para el usuario.
// Las 2 clases que cree quedaron sin uso, ya que lo hice de la forma que se pedia.
class Program
{
    static void Main()
    {
        IDictionary<string, int> estudiantes = new Dictionary<string, int>();

        int opcion;

        do
        {
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. Agregar estudiante y calificacion");
            Console.WriteLine("2. Mostrar calificaciones de los estudiantes");
            Console.WriteLine("3. Modificar la calificación de un estudiante");
            Console.WriteLine("4. Salir");

            Console.WriteLine("\n");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el apellido del estudiante: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese la calificación del alumno: ");
                    int calificacion = int.Parse(Console.ReadLine());

                    if (estudiantes.ContainsKey(nombre))
                    {
                        Console.WriteLine("Ya existe un estudiante con ese nombre.");
                    }
                    else
                    {
                        estudiantes.Add(nombre, calificacion);
                    }
                    Console.WriteLine("\n");
                    break;

                case 2:
                    if(estudiantes.Count > 0)
                    {
                        Console.WriteLine("Clasificaciones de los estudiantes: ");
                        foreach (var skn in estudiantes)
                        {
                            Console.WriteLine($"{skn.Key}: {skn.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay estudiantes");
                    }
                    Console.WriteLine("\n");
                    break;

                case 3:
                    Console.Write("Ingrese el nombre del estudiante para modificar su calificacion: ");
                    string nombreEstudiante = Console.ReadLine();
                    if (estudiantes.ContainsKey(nombreEstudiante))
                    {
                        Console.Write("Agregue la nueva calificacion: ");
                        int nuevacalificacion = int.Parse(Console.ReadLine());
                        estudiantes[nombreEstudiante] = nuevacalificacion;
                    }
                    else
                    {
                        Console.WriteLine("No hay un estudiante con ese nombre");
                    }
                    Console.WriteLine("\n");
                    break;

                case 4:
                    Console.WriteLine("Saliendo");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        } while (opcion != 4);

        Console.WriteLine("Aprete cualquier tecla para terminar la ejecución");
        Console.ReadKey();
    }
}