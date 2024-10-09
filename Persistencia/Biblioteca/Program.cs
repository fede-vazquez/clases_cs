using Biblioteca.Models;

namespace Biblioteca
{
    public class Program
    {
        static void Main()
        {
            SysBiblioteca.CargarDatos();
            int opcion;
            Console.WriteLine("1. Agregar libro.");
            Console.WriteLine("2. Agregar usuario.");
            Console.WriteLine("3. Realizar prestamo.");
            Console.WriteLine("4. Devolver libro.");
            Console.WriteLine("5. Mostrar libros.");
            Console.WriteLine("6. Mostrar usuarios.");
            Console.WriteLine("7. Guardar y Salir.");
            do
            {
                try
                {
                    opcion = Menu.PedirObtenerOpcion();
                } catch(Exception ex)
                {
                    Console.Write(ex.Message);
                    Console.WriteLine("\n");
                    return;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n");
                        Menu.ArmarPedirLibro();
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        Menu.ArmarPedirUsuario();
                        break;
                    case 3:
                        Console.WriteLine("\n");
                        Menu.ArmarPedirPrestamo();
                        break;
                    case 4:
                        Console.WriteLine("\n");
                        Menu.ArmarPedirDevolucion();
                        break;
                    case 5:
                        Console.WriteLine("\n");
                        Menu.MostrarLibros();
                        break;
                    case 6:
                        Console.WriteLine("\n");
                        Menu.MostrarUsuarios();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo...");
                        SysBiblioteca.GuardarDatos();
                        break;
                    default:
                        Console.WriteLine("Opcíon incorrecta.");
                        break;
                }
            } while (opcion != 7);

        }
    }
}