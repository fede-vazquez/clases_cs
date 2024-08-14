class Producto
{
    public string Codigo { get; private set; }
    public string Nombre { get; private set; }
    public int CantidadStock { get; private set; }
    public decimal Precio { get; private set; }

    public Producto(string codigo, string nombre, int cantidadStock, decimal precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        CantidadStock = cantidadStock;
        Precio = precio;
    }

    public void ActualizarStock(int cantidad)
    {
        //Agregar condición para saber si el stock no queda en negativo.
        CantidadStock += cantidad;
    }
}

class OrdenCompra
{
    //De esta forma decimos que va a ser una lista generica de datos tipo Producto.
    private List<Producto> _productos;

    public OrdenCompra()
    {
        _productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        _productos.Add(producto);
    }
    public decimal CalcularTotal()
    {
        decimal total = 0;

        //Alternativa a for, pero para objetos.
        foreach (var producto in _productos)
        {
            total += producto.Precio;
        }

        return total;
    }

    public void MostrarDetalleOrden()
    {
        //mostrar la orden y los productos
        Console.WriteLine($"Detalle de la orden de compra:");
        Console.WriteLine($"Total de la orden: {CalcularTotal()} :c");

        foreach (var producto in _productos)
        {
            Console.WriteLine($"Producto: {producto.Nombre}, Precio {producto.Precio}:c");
        }
    }
    //Agregar método que elimine un producto.
}

class Program
{
    static void Main()
    {

    }
}