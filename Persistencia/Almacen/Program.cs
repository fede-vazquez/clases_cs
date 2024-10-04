using Almacen.Models;

namespace Almacen
{
    class Program
    {
        static void Main()
        {
            Sistema.CargarDatos();
            int opcion;
            do
            {
                Console.WriteLine("\n-------- Menu --------");
                Console.WriteLine("1. Agregar producto.");
                Console.WriteLine("2. Actualizar la cantidad de un producto.");
                Console.WriteLine("3. Mostrar todos los productos.");
                Console.WriteLine("4. Guardar y salir");

                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Sistema.AgregarProducto();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Sistema.MostrarProductos();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                }
            }
            while (opcion != 4);
        }
    }
}