using InventarioProductos.Models;

namespace InventarioProductos
{
    public class Program
    {
        static void Main()
        {
            Sistema.CargarDatos();
            int opcion;

            do
            {
                Console.WriteLine("\n-------- Menu --------");
                Console.WriteLine("1. Agregar producto.");
                Console.WriteLine("2. Eliminar producto.");
                Console.WriteLine("3. Modificar un producto.");
                Console.WriteLine("4. Mostrar productos.");
                Console.WriteLine("5. Guardar y salir");

                try
                {
                    Console.Write("Opcion: ");
                    opcion = Menu.ObtenerOpcion();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("\n");
                        Menu.PedirAgregarProducto();
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        Menu.PedirEliminarProducto();
                        break;
                    case 3:
                        Console.WriteLine("\n");
                        Menu.PedirModificarProducto();
                        break;
                    case 4:
                        Console.WriteLine("\n");
                        Menu.MostrarProductos();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo.");
                        Sistema.GuardarDatos();
                        break;
                    default:
                        Console.WriteLine("Opcion no válida.");
                        break;
                }
            } while (opcion != 5);
        }
    }
}