class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    protected void MostrarDetalle()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
    }
}

class Coche : Vehiculo
{
    public int NumeroPuertas { get; set; }

    public Coche(string marca, string modelo, int numeroPuertas) : base(marca, modelo)
    {
        NumeroPuertas = numeroPuertas;
    }

    public void MostrarInformacionCoche()
    {
        MostrarDetalle(); // Llamada al método protegido de la clase base.
        Console.WriteLine($"Número de puertas: {NumeroPuertas}.");
    }
}

class Program
{
    static void Main()
    {
        Coche coche = new Coche("Toyota", "Corolla", 4);
        coche.MostrarInformacionCoche();
    }
}