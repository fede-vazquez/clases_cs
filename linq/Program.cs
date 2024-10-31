using linq.Models;

namespace linq
{
    public class Program
    {
        static void Main()
        {
            // Ejemplo1();
            // Ejemplo2();
            // Ejemplo3();
            Ejemplo4();
        }

        // order by
        static void Ejemplo1()
        {
            List<Producto> productos = new List<Producto>
            {
                new Producto{ Id = 1, Nombre = "Camiseta", Precio = 25 },
                new Producto{ Id = 2, Nombre = "Pantalón", Precio = 55 },
                new Producto{ Id = 3, Nombre = "Zapatos", Precio = 75 },
                new Producto{ Id = 4, Nombre = "Sombrero", Precio = 30 }
            };

            // Sintaxis linq
            var productosFiltrados =
                from p in productos
                where p.Precio > 50
                orderby p.Nombre ascending
                select p;

            // Sintaxis funcional.
            var productosFiltrados2 =
                productos.Select(p => p)
                .Where(p => p.Precio > 50)
                .OrderBy(p => p.Nombre)
                .ToList();

            foreach (var p in productosFiltrados)
            {
                Console.WriteLine($"{p.Nombre} - {p.Precio:C} - {p.Id}");
            }
        }

        // group by
        static void Ejemplo2()
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante{ Nombre = "Juan", Calificacion = 100},
                new Estudiante{ Nombre = "Luis", Calificacion = 100},
                new Estudiante{ Nombre = "Ana", Calificacion = 92},
                new Estudiante{ Nombre = "Maria", Calificacion = 74},
                new Estudiante{ Nombre = "Carlos", Calificacion = 50}
            };

            var estPorCalificacion =
                from e in estudiantes
                group e by e.Calificacion into grupo
                select grupo;

            foreach (var grupo in estPorCalificacion)
            {
                Console.WriteLine($"Calificación: {grupo.Key}");
                foreach (var e in grupo)
                {
                    Console.WriteLine($" - {e.Nombre}");
                }
            }
        }

        // join
        static void Ejemplo3()
        {
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nombre = "Luis" },
                new Cliente { Id = 2, Nombre = "Ana" },
                new Cliente { Id = 3, Nombre = "Julia" }
            };

            List<Pedido> pedidos = new List<Pedido>
            {
                new Pedido { Id = 1, ClienteId = 1, Producto = "Libro" },
                new Pedido { Id = 2, ClienteId = 3, Producto = "Pala" },
                new Pedido { Id = 3, ClienteId = 2, Producto = "Tablet" },
                new Pedido { Id = 4, ClienteId = 1, Producto = "Cuadernillo" },
            };

            // equals es como == pero no apunta al mismo espacio de memoria, es decir si son iguales aunque esten guardados en distintos lugares.
            var pedidosClientes =
                from c in clientes
                join p in pedidos on c.Id equals p.ClienteId
                select new { c.Nombre, p.Producto };

            foreach (var item in pedidosClientes)
            {
                Console.WriteLine($"{item.Nombre} ha comprado un(a) {item.Producto}");
            }
        }

        // distinct - es como un hashset
        static void Ejemplo4()
        {
            List<string> nombres = new List<string>
            {
                "Ana", "Luis" , "Carlos", "Luis", "Sofía", "Ana"
            };

            // Al poner la sentencia dentro de parentesis puedo ya utilizarla como si fuera una lista, porque es lo que me devuelve.
            var nombresUnicos =
                (from n in nombres
                 select n).Distinct();

            foreach (var n in nombresUnicos)
            {
                Console.WriteLine(n);
            }
        }
    }
}