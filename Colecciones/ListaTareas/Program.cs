using ListaTareas.Models;
using System.ComponentModel;
public class Program
{
    static void Main()
    {
        List<Tarea> tareas = new List<Tarea>();

        int opcion;

        do
        {
            Console.WriteLine("1- Agregar tarea");
            Console.WriteLine("2- Marcar una tarea como completada");
            Console.WriteLine("3- Mostrar todas las tareas");
            Console.WriteLine("4- Salir");
            Console.WriteLine("\n");

            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            switch (opcion)
            {
                case 1:
                    Console.Write("Agregar nueva tarea: ");
                    string tituloTarea = Console.ReadLine();
                    tareas.Add(new Tarea(tituloTarea));
                    Console.WriteLine($"Se agrego la tarea: {tituloTarea}\n");
                    break;

                case 2:
                    Console.WriteLine("Que tarea desea completar?\n");
                    for(int i = 0; i < tareas.Count; i++)
                    {
                        Console.WriteLine($"{i+1}- {tareas[i].Descripcion}, Completada: {tareas[i].IsCompletada}");
                    }
                    Console.Write("Seleccione la tarea a completar: ");
                    int indiceTareaSeleccionada = int.Parse(Console.ReadLine()) - 1;

                    if(indiceTareaSeleccionada >= 0 && indiceTareaSeleccionada < tareas.Count)
                    {
                        tareas[indiceTareaSeleccionada].CompletarTarea();
                        Console.WriteLine("Tarea completada.");
                    }
                    else
                    {
                        Console.WriteLine("Número de tarea inválido.\n");
                    }
                    break;

                case 3:
                    Console.WriteLine("Tareas pendientes:");
                    for(int i = 0; i < tareas.Count; i++)
                    {
                        if (!tareas[i].IsCompletada)
                        Console.WriteLine($"{i+1}- {tareas[i].Descripcion}");
                    }
                    Console.WriteLine("\n");
                    break;
            }

        } while (opcion != 4);
    }
}
// tarea para despues:
// mostrar todas las tareas.
// mostrar tareas completadas.
// editar una tarea.