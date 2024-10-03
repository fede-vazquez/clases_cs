// Esta mal el nombre de esta clase, ya que está haciendo más de una cosa.
namespace Contactos.Models
{
    public static class Sistema
    {
        private static string archivo = "contactos.txt";
        private static char sc = '|';

        private static List<Contacto> Contactos = new List<Contacto>();
        // No validé si ya había un contacto igual.
        public static void AgregarContacto()
        {
            Console.Write("Agregar nombre de contacto: ");
            string nombre = Console.ReadLine();

            Console.Write("Agregar telefono de contacto: ");
            int telefono = int.Parse(Console.ReadLine());

            Console.Write("Agregar correo de contacto: ");
            string correo = Console.ReadLine();

            Contacto c = new Contacto(nombre, telefono, correo);
            Contactos.Add(c);
            GuardarContacto(c);
        }

        public static void MostrarContactos()
        {
            if(Contactos.Count > 0)
            {
                Console.WriteLine("Contactos: ");
                foreach (var c in Contactos)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("No hay contactos para mostrar.");
            }
        }

        public static void GuardarContactos()
        {
            // El segundo parámetro es un booleano que me dice que va a agregar una liena al archivo pero no sobreescribirlo.
            using StreamWriter writer = new StreamWriter(archivo, true);
            writer.WriteLine();
            foreach (var c in Contactos)
            {
                writer.WriteLine($"{c.Nombre}{sc}{c.Telefono}{sc}{c.CorreoElectronico}");
            }
        }

        public static void GuardarContacto(Contacto c)
        {
            using StreamWriter writer = new StreamWriter(archivo, true);
            writer.WriteLine($"{c.Nombre}{sc}{c.Telefono}{sc}{c.CorreoElectronico}");
        }

        public static void CargarContactos()
        {
            if (File.Exists(archivo))
            {
                string linea;
                using StreamReader reader = new StreamReader(archivo);

                while ((linea = reader.ReadLine()) != null)
                {
                    string[] partes = linea.Split(sc);

                    Contacto c = new Contacto(partes[0], int.Parse(partes[1]), partes[2]);
                    Contactos.Add(c);
                }
                Console.WriteLine("Usuarios cargados.");
            }
        }
    }
}
