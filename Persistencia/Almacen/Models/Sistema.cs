namespace Almacen.Models
{
    public static class Sistema
    {
        static char sa = '|';
        static string nombreArchivo = "productos.txt";

        // no se como traerme los datos.
        private static Dictionary<int, Producto> Productos = new Dictionary<int, Producto>();

        public static void AgregarProducto()
        {
            Console.Write("Ingresar nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresar stock del producto: ");
            int stock = int.Parse(Console.ReadLine());

            Console.Write("Ingresar código del producto: ");
            int codigo = int.Parse(Console.ReadLine());

            Producto p = new Producto(nombre, stock, codigo);

            if (!Productos.ContainsKey(p.Codigo))
            {
                Productos[p.Codigo] = p;
                SistemaArchivo.GuardarDato(nombreArchivo, p, true);
                Console.WriteLine("Producto agregado correctamente.");
            }
            else
            {
                Console.WriteLine("El código generado automaticamente ya es parte de otro producto.");
            }
        }

        public static void MostrarProductos()
        {
            Console.WriteLine("Productos: ");
            foreach (var p in Productos.Values)
            {
                string[] partes = p.ToString().Split(sa);
                Console.WriteLine($"Código: {partes[0]}, Nombre: {partes[1]}, Stock: {partes[2]}");
            }
        }

        public static void CargarDatos()
        {
            List<string> datos = SistemaArchivo.ObtenerDatos(nombreArchivo);

            Productos.Clear();
            foreach (var texto in datos)
            {
                string[] partes = texto.Split(sa);

                int codigo = int.Parse(partes[0]);
                string nombre = partes[1];
                int stock = int.Parse(partes[2]);

                Producto product = new Producto(nombre, stock, codigo);

                Productos[codigo] = product;
            }
        }
    }
}
