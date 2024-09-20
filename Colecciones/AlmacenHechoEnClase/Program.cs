public class Producto
{
    public int Codigo { get; private set; }
    public string Nombre { get; private set; }
    public int Cantidad { get; set; }

    public Producto(int codigo, string nombre, int cantidad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Cantidad = cantidad;
    }
}

public class Program
{
    static void Main()
    {
        Dictionary<int, Producto> almacen = new Dictionary<int, Producto>();
        int opcion;

        do
        {
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Actualizar stock");
            Console.WriteLine("3. Mostrar productos en stock");
            Console.WriteLine("4. Salir");

            Console.WriteLine("\n");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el código del producto: ");
                    int codigo = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el nombre del producto: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese la cantidad del producto: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    Producto p = new Producto(codigo, nombre, cantidad);
                    almacen.TryAdd(codigo, p);

                    Console.WriteLine("\n");
                    break;

                case 2:
                    Console.Write("Ingrese el código del producto a actualizar: ");
                    int cod = int.Parse(Console.ReadLine());
                    if (almacen.ContainsKey(cod))
                    {
                        Console.Write("Ingrese la nueva cantidad: ");
                        int cant = int.Parse(Console.ReadLine());
                        almacen[cod].Cantidad = cant;
                        Console.WriteLine("Cantidad actualizada");
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }

                    Console.WriteLine("\n");
                    break;

                case 3:
                    Console.WriteLine("Productos en stock: ");
                    foreach (var pr in almacen.Values)
                    {
                        Console.WriteLine($"Código: {pr.Codigo}, Nombre: {pr.Nombre}, cantidad: {pr.Cantidad}");
                    }
                    Console.WriteLine("\n");
                    break;
            }

        } while (opcion !=4);

        Console.WriteLine("Pulse cualquier tecla para finalizar");
        Console.ReadKey();
    }
}