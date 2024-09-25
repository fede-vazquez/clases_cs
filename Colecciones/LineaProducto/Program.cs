class Producto
{
    public string Nombre { get; set; }
    public int TiempoProcesamiento { get; set; }

    public Producto(string nombre, int tiempoProcesamiento)
    {
        Nombre = nombre;
        TiempoProcesamiento = tiempoProcesamiento;
    }
}
class Program
{
    static void Main()
    {
        Queue<Producto> lineaProducto = new Queue<Producto>();

        lineaProducto.Enqueue(new Producto("Laptop", 6));
        lineaProducto.Enqueue(new Producto("Telefono", 8));
        lineaProducto.Enqueue(new Producto("Mouse", 2));
        
        while(lineaProducto.Count > 0)
        {
            Producto unProducto = lineaProducto.Dequeue();
            Console.WriteLine($"Ensamblando {unProducto.Nombre} por {unProducto.TiempoProcesamiento}");
        }
    }
}