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
        if(CantidadStock + cantidad < 0)
        {
            Console.WriteLine($"\nLa cantidad de {Nombre} que intentaste retirar es mayor a la cantidad en stock.");
        }
        else
        {
            CantidadStock += cantidad;
            Console.WriteLine($"\nEl nuevo stock de {Nombre} es de {CantidadStock}");
        }
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
        if (_productos.Count != 0)
        {
            Console.WriteLine($"\nDetalle de la orden de compra:");
            Console.WriteLine($"Total de la orden: {CalcularTotal()}");

            foreach (var producto in _productos)
            {
                Console.WriteLine($"Producto: {producto.Nombre}, Precio {producto.Precio}");
            }
        }
        else
        {
            Console.WriteLine("Todavía no hay productos agregados a la orden de compra.");
        }
    }
    //Agregar método que elimine un producto.
    public void EliminarProducto(Producto producto)
    {
        _productos.Remove(producto);
    }
}

class Program
{
    static void Main()
    {
        Producto manzana = new Producto("QTJ-2GS", "Manzana", 40, 350);
        Producto leche = new Producto("RCY-5Qh", "Leche", 20, 2500);
        Producto pollo = new Producto("P4D-1J5", "Pollo", 15, 6000);

        OrdenCompra ordenCompra = new OrdenCompra();

        ordenCompra.MostrarDetalleOrden();

        ordenCompra.AgregarProducto(manzana);
        ordenCompra.AgregarProducto(manzana);
        ordenCompra.AgregarProducto(leche);
        ordenCompra.AgregarProducto(pollo);

        ordenCompra.MostrarDetalleOrden();

        ordenCompra.EliminarProducto(manzana);
        ordenCompra.EliminarProducto(leche);

        ordenCompra.MostrarDetalleOrden();

        manzana.ActualizarStock(30);

        pollo.ActualizarStock(-16);
    }
}