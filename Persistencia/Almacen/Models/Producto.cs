namespace Almacen.Models
{
    public class Producto
    {
        static int __codigoProducto = 0;
        public int Codigo { get; private set; }
        private string Nombre;
        public int CantidadStock { get; private set; }

        public Producto(string nombre, int cantidadStock)
        {
            Codigo = ++__codigoProducto;
            Nombre = nombre;
            CantidadStock = cantidadStock;
        }

        public override string ToString()
        {
            return $"{Codigo}|{Nombre}|{CantidadStock}";
        }
    }
}
