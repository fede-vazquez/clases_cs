namespace InventarioProductos.Models
{
    public static class Sistema
    {
        static string archivoProductos = "productos.txt";
        private static List<Producto> Productos = new List<Producto>();

        public static List<Producto> ObtenerProductos() => Productos;
        public static void AgregarProducto(Producto producto) => Productos.Add(producto);
        public static void EliminarProducto(string nom)
        {
            Producto p = Productos.Find(p => p.Nombre == nom);

            if (p != null)
            {
                Productos.Remove(p);
                Console.WriteLine("Producto eliminado.");
            }
            else
            {
                Console.WriteLine($"El producto: {nom} no se encontro.");
            }
        }
        // refactorizár esto.
        public static void ModificarProducto(string nomProducto, string nuevoNombre, string nuevoPrecio, string nuevaCantidad)
        {
            Producto pr = Productos.Find(p => p.Nombre == nomProducto);

            if(pr != null)
            {
                if(!string.IsNullOrWhiteSpace(nuevoNombre)) pr.Nombre = nuevoNombre;
                if (!string.IsNullOrWhiteSpace(nuevoPrecio)) pr.Precio = double.Parse(nuevoPrecio); 
                if (!string.IsNullOrWhiteSpace(nuevaCantidad)) pr.Cantidad = int.Parse(nuevaCantidad);
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        public static void GuardarDatos()
        {
            if (Productos.Count == 0) return;

            using StreamWriter writer = new StreamWriter(archivoProductos);
            foreach (var p in Productos)
            {
                writer.WriteLine(p);
            }
        }

        public static void CargarDatos()
        {
            if (!File.Exists(archivoProductos)) return;
            
            using StreamReader reader = new StreamReader(archivoProductos);

            string linea;
            while((linea = reader.ReadLine()) != null)
            {
                string[] p = linea.Split('-');

                Producto pr = new Producto(p[0], double.Parse(p[1]), int.Parse(p[2]));
                Productos.Add(pr);
            }
        }
    }
}