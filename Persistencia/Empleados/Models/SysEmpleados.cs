using SistemaEmpleados.Enums;

namespace SistemaEmpleados.Models
{
    public static class SysEmpleados
    {
        static string ArchivoEmpleados = "empleados.txt";

        static Dictionary<int, Empleado> Empleados = new();

        public static void MostrarEmpleados()
        {
            if(Empleados.Count > 0)
            {
                Console.WriteLine("\nLista de empleados: ");
                foreach (var emp in Empleados.Values)
                {
                    Console.WriteLine(emp);
                }
            }
            else
            {
                Console.WriteLine("No hay empleados.");
            }
        }

        public static void AgregarEmpleado()
        {
            int id, edad, deptIndex;
            string nombre = null!;
            Departamento departamento = Departamento.RecursosHumanos;
            bool valid;

            do
            {
                Console.Write("Ingresa el ID del empleado: ");
                valid = int.TryParse(Console.ReadLine(), out id);
                // Esto es para no parar la ejecución del programa.
                if (!valid) { Console.WriteLine("El dato no es de tipo entero."); }
            } while (!valid);
            valid = false;

            do
            {
                Console.Write("Ingresa el nombre del empleado: ");
                nombre = Console.ReadLine();
                // Esto es para no parar la ejecución del programa.
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine("El nombre no debe estar vacío.");
                }
                else { valid = true; }
            } while (!valid);
            valid = false;

            do
            {
                Console.Write("Ingresa la edad del empleado: ");
                valid = int.TryParse(Console.ReadLine(), out edad);
                // Esto es para no parar la ejecución del programa.
                if (!valid) { Console.WriteLine("El dato no es de tipo entero."); }
            } while (!valid);
            valid = false;

            do
            {
                Console.WriteLine("Seleccione el departamento del empleado: ");
                // GetValues() toma como parametro un tipo de enum. Por eso utilizamos el typeof(Departamentos).
                foreach (var dept in Enum.GetValues(typeof(Departamento)))
                {
                    // (int)dept da la posición del enum.
                    Console.WriteLine($"{(int)dept}. {dept}");
                }

                valid = int.TryParse(Console.ReadLine(), out deptIndex);
                if (!valid)
                { 
                    Console.WriteLine("El dato no es de tipo númerico.");
                }
                else
                {
                    // (Departamento)deptIndex; hace lo contrario a (int)dept
                    departamento = (Departamento)deptIndex;
                }
            } while (!valid);

            var emp = new Empleado(id, nombre, edad, departamento);
            Empleados.Add(id, emp);
            GuardarEmpleado(emp);
            Console.WriteLine($"Empleado {nombre} agregado");
        }

        public static void ActualizarEmpleado()
        {
            Console.WriteLine("Ingrese el ID del usuario para modificar: ");
            int id = int.Parse(Console.ReadLine());

            if (Empleados.ContainsKey(id))
            {
                Console.WriteLine("(Precione 'enter' para omitir)");
                Empleado emp = Empleados[id];

                Console.Write("Ingrese el nombre a modificar: ");
                string nombre = Console.ReadLine();
                if(!string.IsNullOrEmpty(nombre)) emp.Nombre = nombre;

                Console.Write("Ingrese la edad a modificar: ");
                string edad = Console.ReadLine();
                if (!string.IsNullOrEmpty(edad)) emp.Edad = int.Parse(edad);

                Console.WriteLine("Seleccione el nuevo departamento: ");
                foreach (var dept in Enum.GetValues(typeof(Departamento)))
                {
                    // (int)dept da la posición del enum.
                    Console.WriteLine($"{(int)dept}. {dept}");
                }
                string deptIndex = Console.ReadLine();
                if (!string.IsNullOrEmpty(deptIndex))
                {
                    emp.Departamento = (Departamento)int.Parse(deptIndex);
                }

                GuardarDatos();
                Console.WriteLine("Empleado modificado.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        public static void EliminarEmpleado()
        {
            Console.Write("Ingrese el id del empleado a eliminar.");
            var id = int.Parse(Console.ReadLine());

            if (Empleados.Remove(id))
            {
                Console.WriteLine("Empleado eliminado.");
                GuardarDatos();
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        static void GuardarEmpleado(Empleado emp)
        {
            using StreamWriter writer = new(ArchivoEmpleados, true);
            writer.WriteLine(emp);
        }

        static void GuardarDatos()
        {
            using StreamWriter writer = new(ArchivoEmpleados);

            foreach (var emp in Empleados.Values)
            {
                writer.WriteLine(emp);
            }
        }

        public static void CargarDatos()
        {
            if (!File.Exists(ArchivoEmpleados)) return;

            foreach (var linea in File.ReadAllLines(ArchivoEmpleados))
            {
                var partes = linea.Split(", ");
                int id = int.Parse(partes[0]);
                string nombre = partes[1];
                int edad = int.Parse(partes[2]);
                // Pasar un string de enum a enum. Tambien tiene el tryparse.
                Departamento departamento = (Departamento)Enum.Parse(typeof(Departamento), partes[3]);

                Empleado emp = new Empleado(id, nombre, edad, departamento);
                Empleados.Add(id, emp);
            }
            Console.WriteLine("Datos cargados.");
        }
    }
}

// Practicar create y updates, ya que son los más complicados.
// Importante conocer como trabajar con enums.