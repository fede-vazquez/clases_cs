/*
    Estás implementando una pequeña aplicación para gestionar un registro de contactos.
    Cada contacto tiene un nombre, un número de teléfono y un correo electrónico.
    El sistema debe permitir agregar nuevos contactos, mostrar todos los contactos almacenados,
    y guardar la información en un archivo de texto para que persista entre sesiones.

    Requerimientos:
    1. Crea una clase Contacto con las propiedades Nombre, Telefono y CorreoElectronico.
    2. Usa una Lista (List<Contacto>) para almacenar los contactos.
    3. El sistema debe permitir:
    - Agregar nuevos contactos.
    - Mostrar todos los contactos.
    - Guardar los contactos en un archivo de texto al salir del programa.
    - Cargar los contactos desde el archivo de texto al iniciar el programa.
 */

using Contactos.Models;

public class Program
{
    static void Main()
    {
        Sistema.CargarContactos();
        int opcion;
        do
        {
            Console.WriteLine("\n-------- Menu --------");
            Console.WriteLine("1. Agregar contacto.");
            Console.WriteLine("2. Mostrar contactos.");
            Console.WriteLine("3. Guardar y salir");

            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Sistema.AgregarContacto();
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Sistema.MostrarContactos();
                    Console.WriteLine("\n");
                    break;
                case 3:
                    Sistema.GuardarContactos();
                    Console.WriteLine("\n");
                    break;
                default:
                    Console.WriteLine("Opción no valida.");
                    break;
            }
        }
        while (opcion != 3);
    }
}
// Investigar: Al momento de guardar un contacto que no se sobreescriba todo, sinó que lo deje y agregue al final.