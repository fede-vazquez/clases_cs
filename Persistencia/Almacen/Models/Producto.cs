namespace Almacen.Models
{
    public class Producto
    {
        public int Codigo { get; private set; }
        private string Nombre;
        public int CantidadStock { get; private set; }

        public Producto(string nombre, int cantidadStock, int codigo)
        {
            Codigo = codigo;
            Nombre = nombre;
            CantidadStock = cantidadStock;
        }

        public override string ToString()
        {
            return $"{Codigo}|{Nombre}|{CantidadStock}";
        }
    }
}
