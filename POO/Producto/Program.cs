class Producto
{
    private string _nombre;
    private decimal _precio;
    private int _cantidadEnStock;

    public Producto(string nombre, decimal precio, int stockInicial)
    {
        _nombre = nombre;
        _precio = precio;
        _cantidadEnStock = stockInicial;
    }

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public decimal Precio
    {
        get { return _precio; }
        set { _precio = value; }
    }
    public int CantidadEnStock
    {
        get { return _cantidadEnStock;}
        set { _cantidadEnStock = value; }
    }

    public void ActualizarCantidadEnStock(int cantidad)
    {
        if(CantidadEnStock + cantidad >= 0)
        {
            CantidadEnStock += cantidad;
            Console.WriteLine($"Cantidad en stock actualizada: {CantidadEnStock}.");
        }
        else
        {
            Console.WriteLine($"Cantidad no válida para actualizar el stock.");
        }
    }
}

class Program
{
    //static es cuando el atributo o metodo no pertenecen al objeto que se vaya a instanciar, sino a la clase.
    static void Main()
    {
        Producto producto = new Producto("Laptop", 1200, 50);

        Console.WriteLine($"Nombre: {producto.Nombre}.");
        Console.WriteLine($"Precio: {producto.Precio}.");
        Console.WriteLine($"Cantidad en stock: {producto.CantidadEnStock}.");

        producto.ActualizarCantidadEnStock(20);
        producto.ActualizarCantidadEnStock(-70);
        producto.ActualizarCantidadEnStock(30);
        producto.ActualizarCantidadEnStock(-40);
    }
}