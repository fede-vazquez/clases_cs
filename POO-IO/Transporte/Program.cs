using System.Net.WebSockets;

class Transporte
{
    public string Nombre { get; set; }

    public Transporte(string nombre)
    {
        Nombre = nombre;
    }

    // Metodo virtual: Es un método abstracto y se puede sobreescribir.
    public virtual void Desplazarse()
    {
        Console.WriteLine("El vehículo se desplaza...");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Vehículo: {Nombre}");
        Desplazarse();
    }
}

class Auto : Transporte
{
    public Auto(string nombre) : base(nombre) { }

    public override void Desplazarse()
    {
        Console.WriteLine("El auto se desplaza por la autopista.");
    }
}

class Bicicleta : Transporte
{
    public Bicicleta(string nombre) : base(nombre) { }

    public override void Desplazarse()
    {
        Console.WriteLine("La bicicleta se desplaza por la bicisenda.");
    }
}

class Avion : Transporte
{
    public Avion(string nombre) : base(nombre) { }

    public override void Desplazarse()
    {
        Console.WriteLine("El avion se desplaza por el aire.");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el nombre del auto: ");
        Transporte miAuto = new Auto(Console.ReadLine() ?? "");
        miAuto.MostrarInformacion();

        Console.Write("\nIngrese el nombre de la bici: ");
        Transporte miBici = new Bicicleta(Console.ReadLine() ?? "");
        miBici.MostrarInformacion();

        Console.Write("\nIngrese el nombre del avion: ");
        Transporte miAvion = new Avion(Console.ReadLine() ?? "");
        miAvion.MostrarInformacion();
    }
}