using ListaDeTareas.Models;

namespace ListaDeTareas
{
    class Program
    {
        static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n-------- Menu --------");
                Console.WriteLine("1. Agregar usuario.");
                Console.WriteLine("2. Agregar tarea a usuario.");
                Console.WriteLine("3. Cambiar el estado de tarea.");
                Console.WriteLine("4. Mostrar tareas de un usuario.");
                Console.WriteLine("5. Guardar y salir");

                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Sistema.AgregarUsuario();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Sistema.AgregarTareaAUsuario();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Sistema.CambiarEstadoTareaDeUsuario();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Sistema.MostrarTareasDeUsuario();
                        Console.WriteLine("\n");
                        break;
                }
            }
            while (opcion != 5);

            Sistema.GuardarDatos();
        }
    }
}