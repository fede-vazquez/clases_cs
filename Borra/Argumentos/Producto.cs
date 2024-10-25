namespace Argumentos
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; } = 0;
        public int Stock { get; set; } = 0;

        public Producto(string nombre, double precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }


    }
}
