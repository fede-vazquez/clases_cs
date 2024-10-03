using ContadorPalabras.Models;

public class Program
{
    static void Main()
    {
        SistemaTextosArchivo.CargarDeArchivo();
        int opcion;

        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("==== Menú ===");
            Console.WriteLine("1. Agregar texto y mostrar frecuencia.");
            Console.WriteLine("2. Listar textos anteriores.");
            Console.WriteLine("3. Seleccionar texto anterior.");
            Console.WriteLine("4. Salir y guardar.");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (opcion)
            {
                case 1:
                    Sistema.AgregarTexto();
                    Sistema.CalcularFrecuenciaPalabras();
                    Sistema.MostrarFrecuenciaPalabras();
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Sistema.ListarTextos();
                    Console.WriteLine("\n");
                    break;
                case 3:
                    Sistema.CambiarTextoActual();
                    Sistema.MostrarFrecuenciaPalabras();
                    Console.WriteLine("\n");
                    break;
                case 4:
                    SistemaTextosArchivo.GuardarEnArchivo();
                    Console.WriteLine("Saliendo");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta.");
                    break;
            }

        } while (opcion != 4);

    }
}

// Pila, porque no se enumera, me van quedando en el orden en el que las ingreso, y no las voy a modificar.
// Un menú con estas opciones:
// Agregar frases y mostrar frecuencia.
// Listar frases.
// Elegir una y mostrar la frecuencia.
// Guardar en archivo.