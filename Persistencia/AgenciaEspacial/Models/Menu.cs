using AgenciaEspacial.Enums;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace AgenciaEspacial.Models
{
    public static class Menu
    {
        private static List<Action> acciones = new List<Action>
        {
            AgregarMision,
            MostrarMisiones,
            ModificarMision,
            EliminarMision,
        };
        public static void MostrarMenu()
        {
            bool salir = false;

            while(!salir)
            {
                Console.WriteLine("\n --- Menú de misiones ---\n" +
                    "1. Agregar misión\n" +
                    "2. Mostrar misiones\n" +
                    "3. Modificar misión\n" +
                    "4. Eliminar misión\n" +
                    "5. Salir\n");

                Console.WriteLine("Seleccione una ocpión: ");
                string opcion = Console.ReadLine();

                if(int.TryParse(opcion, out int indice) && indice >= 1 && indice <= acciones.Count + 1)
                {
                    if(indice == acciones.Count + 1)
                    {
                        salir = true;
                    }
                    else
                    {
                        acciones[indice - 1].Invoke();
                    }
                }
            }
        }

        static Mision CrearMision(string nombre)
        {
            int seleccion = int.Parse(Console.ReadLine());

            Destino destinoSeleccionado = (Destino)seleccion;

            Console.Write("Ingrese la cantida de astronautas: ");
            int astronautas = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione el tipo de misión: ");
            Console.WriteLine("1. Exploración.");
            Console.WriteLine("2. Colonización.");
            Console.WriteLine("3. Investigación.");

            int tipo = int.Parse(Console.ReadLine());

            Mision nuevaMision = null;

            switch (tipo)
            {
                case 1:
                    nuevaMision = new Exploracion(nombre, destinoSeleccionado, astronautas);
                    break;
                case 2:
                    Console.Write("Ingrese la cantidad de colonos: ");
                    int colonos = int.Parse(Console.ReadLine());
                    nuevaMision = new Colonizacion(nombre, destinoSeleccionado, astronautas, colonos);
                    break;
                case 3:
                    Console.Write("Ingrese el campo de investigación: ");
                    string campo = Console.ReadLine();
                    nuevaMision = new Investigacion(nombre, destinoSeleccionado, astronautas, campo);
                    break;
                default:
                    Console.WriteLine("Tipo de misión inválida.");
                    break;
            }

            return nuevaMision;
        }

        static void AgregarMision()
        {
            Console.Write("Ingrese el nombre de la misión: ");
            string nombre = Console.ReadLine();

            Mision m = CrearMision(nombre);

            GestionMisiones.AgregarMision(m);
        }

        // esto es una closure
        static void MostrarMisiones() => GestionMisiones.MostrarMisiones();

        static void ModificarMision()
        {
            Console.Write("Ingrese el nombre de la misión: ");
            string nombre = Console.ReadLine();

            var nuevaMision = CrearMision(nombre);

            GestionMisiones.ModificarMision(nombre, nuevaMision);
        }

        static void EliminarMision()
        {
            Console.Write("Ingrese el nombre de la misión: ");
            string nombre = Console.ReadLine();
            GestionMisiones.EliminarMision(nombre);
        }
    }
}
