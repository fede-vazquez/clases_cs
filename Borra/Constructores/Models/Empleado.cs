namespace Constructores.Models
{
    public class Empleado
    {
        public int Id { get; private set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public static int TotalEmpleados { get; private set; }
        private static int Ids = 1;

        // 1. Constructor por defecto, sin parámetros.
        public Empleado()
        {
            Id = Ids++;
            Nombre = "sin nombr";
            Departamento = "Sin asignar";
            TotalEmpleados++;
            Console.WriteLine("Empleado creado con datos predeterminados.");
        }

        // 2. Constructor parametrizado.
        public Empleado(string nombre, string departamento)
        {
            Id = Ids++;
            Nombre = nombre;
            Departamento = departamento;
            TotalEmpleados++;
            Console.WriteLine($"Empleado {Nombre} creado.");
        }

        // 3. Constructor de copia.
        public Empleado(Empleado empleado)
        {
            Id = empleado.Id;
            Nombre = empleado.Nombre;
            Departamento= empleado.Departamento;
            TotalEmpleados++;
            Console.WriteLine($"Empleado copiado: {Nombre}");
        }

        // 4. Constructor estático.
        // Se centra en afectar a las propiedades/métodos estáticos
        // Se ejecuta al iniciar el programa.
        static Empleado()
        {
            TotalEmpleados = 0;
            Console.WriteLine("Sistema de empleados inicializado.");
        }

        // 5. Constructor privado. (solo accesible internamente)
        // se podría utilizar para crear un usuario administrador.
        private Empleado(string nombre)
        {
            Id = -1;
            Nombre = nombre;
            Departamento = "Administración";
            TotalEmpleados++;
            Console.WriteLine($"Administrador {Nombre} creado.");
        }

        // Método estático para crear un Administrador (utiliza el constructor privado)
        public static Empleado CrearAdministrador(string nombre)
        {
            return new Empleado(nombre);
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Id: {Id}, Nombre: {Nombre}, Departamento: {Departamento}");
        }
    }
}