namespace InventarioProductos.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto(string nombre, double precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"{Nombre}-{Precio}-{Cantidad}";
        }
    }
}
