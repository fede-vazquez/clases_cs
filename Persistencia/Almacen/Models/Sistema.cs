namespace Almacen.Models
{
    public static class Sistema
    {
        static string nombreArchivo = "productos.txt";

        // no se como traerme los datos.
        private static Dictionary<int, Producto> Productos;

        public static void AgregarProducto()
        {
            Console.Write("Ingresar nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresar stock del producto: ");
            int stock = int.Parse(Console.ReadLine());

            Producto p = new Producto(nombre, stock);

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
                string[] partes = p.ToString().Split("|");
                Console.WriteLine($"Código: {partes[0]}, Nombre: {partes[1]}, Stock: {partes[2]}");
            }
        }
    }
}
