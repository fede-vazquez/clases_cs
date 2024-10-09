namespace InventarioProductos.Models
{
    public static class Menu
    {
        public static int ObtenerOpcion()
        {
            int opcion;

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                throw new Exception("No se ingreso un número.");
            }
            return opcion;
        }

        public static void PedirAgregarProducto()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nom = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            int pre = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantdiad del producto: ");
            int cant = int.Parse(Console.ReadLine());

            Producto p = new Producto(nom, pre, cant);

            Sistema.AgregarProducto(p);
            Console.WriteLine("Producto agregado.");
        }

        public static void PedirEliminarProducto()
        {
            Console.Write("Ingrese el nombre del producto a eliminar: ");
            string nom = Console.ReadLine();

            Sistema.EliminarProducto(nom);

        }

        public static void MostrarProductos()
        {
            List<Producto> productos = Sistema.ObtenerProductos();

            if (productos.Count > 0)
            {
                Console.WriteLine("Productos:");
                foreach (var p in productos)
                {
                    Console.WriteLine($"Nombre: {p.Nombre}, precio: {p.Precio}, cantidad: {p.Cantidad}");
                }
            }
            else
            {
                Console.WriteLine("No hay productos para mostrar.");
            }
        }

        public static void PedirModificarProducto()
        {
            Console.Write("Ingresar nombre del producto para modificar: ");
            string nom = Console.ReadLine();

            Console.WriteLine("Preciona la tecla 'enter' para no actualizar y omitir.");

            Console.Write("Ingrese el nuevo nombre del producto: ");
            string nuevoNombre = Console.ReadLine();

            Console.Write("Ingrese el nuevo precio del producto: ");
            string nuevoPrecio = Console.ReadLine();

            Console.Write("Ingrese la nueva cantidad del producto: ");
            string nuevaCantidad = Console.ReadLine();

            Sistema.ModificarProducto(nom, nuevoNombre, nuevoPrecio, nuevaCantidad);
        }
    }
}
