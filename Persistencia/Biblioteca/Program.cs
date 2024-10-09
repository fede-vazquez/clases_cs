using Biblioteca.Models;

namespace Biblioteca
{
    public class Program
    {
        static void Main()
        {
            SysBiblioteca.CargarDatos();
            int opcion;

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
                }
            } while (opcion != 5);

            SysBiblioteca.GuardarDatos();
        }
    }
}