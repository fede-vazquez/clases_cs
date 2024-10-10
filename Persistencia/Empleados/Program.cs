using SistemaEmpleados.Models;

namespace SistemaEmpleados
{
    public class Program
    {
        static void Main()
        {
            SysEmpleados.CargarDatos();
            int opcion;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. Agregar Empleado.");
                Console.WriteLine("2. Eliminar Empleado.");
                Console.WriteLine("3. Modificar Empleado.");
                Console.WriteLine("4. Mostrar Empleado.");
                Console.WriteLine("5. Salir.");

                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        SysEmpleados.AgregarEmpleado();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        SysEmpleados.EliminarEmpleado();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        SysEmpleados.ActualizarEmpleado();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        SysEmpleados.MostrarEmpleados();
                        Console.WriteLine("\n");
                        break;
                }
            } while (opcion != 5);
        }
    }
}

// Agregar opción listar por departamento, y le muestre todos los empleados que tengan ese departamento.