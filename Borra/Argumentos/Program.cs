
using Argumentos;

public class Program
{
    static void Main()
    {
        Producto producto = new Producto("Yerba", 5000.0, 10);

        Tienda tienda = new Tienda();

        // Datos del pedido.
        int cantidadPedida = 2;

        Console.WriteLine($"El producto: {producto.Nombre}");
        Console.WriteLine($"Stock disponible: {producto.Stock}");

        tienda.MostrarPrecioUnitario(producto.Precio);

        tienda.CalcularCostoTotal(cantidadPedida, producto.Precio);

        // Hay que ponerle ref al comienzo.
        int stock = producto.Stock;
        tienda.DespacharProducto(ref stock, cantidadPedida);

        Console.WriteLine($"Stock: {stock}");

        tienda.CalcularUnidadesFaltantes(producto.Stock, cantidadPedida, out int unidadesFaltantes);
        if(unidadesFaltantes > 0)
        {
            Console.WriteLine($"Faltan por despachar {unidadesFaltantes} unidades.");
        }
        else
        {
            Console.WriteLine("Todas las unidades fueron despachadas.");
        }
    }
}