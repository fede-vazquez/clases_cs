class Vehiculo
{
    public string Modelo { get; set; }
    public string Marca { get; set; }

    public Vehiculo(string modelo, string marca)
    {
        Modelo = modelo;
        Marca = marca;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
    }
}

class VehiculoCuatroRuedas : Vehiculo
{
    public int NumeroPuertas { get; set; }

    public VehiculoCuatroRuedas(string modelo, string marca, int numeroPuertas) : base(modelo, marca)
    {
        NumeroPuertas = numeroPuertas;
    }

    public void MostrarInformacionCuatroRuedas()
    {
        MostrarInformacion();
        Console.WriteLine($"NumeroPuertas: {NumeroPuertas}");
    }
}

class Coche : VehiculoCuatroRuedas
{
    public string TipoCombustible { get; set; }

    public Coche(string modelo, string marca, int numeroPuertas, string tipoCombustible) : base(modelo, marca, numeroPuertas)
    {
        TipoCombustible = tipoCombustible;
    }

    public void MostrarInformacionCoche()
    {
        MostrarInformacionCuatroRuedas();
        Console.WriteLine($"Tipo de combustible: {TipoCombustible}");
    }

}

class Program
{
    static void Main()
    {
        string marca, modelo, tipoCombustible;
        int numeroPuertas;

        Console.Write("Ingrese marca del coche: ");
        marca = Console.ReadLine();
        
        Console.Write("Ingrese modelo del coche: ");
        modelo = Console.ReadLine();

        Console.Write("Ingrese el numero de puertas del coche: ");
        int.TryParse(Console.ReadLine(), out numeroPuertas);

        Console.Write("Ingrese tipo de combustible del coche: ");
        tipoCombustible = Console.ReadLine();

        Coche coche = new Coche(modelo, marca, numeroPuertas, tipoCombustible);

        coche.MostrarInformacionCoche();
    }
}