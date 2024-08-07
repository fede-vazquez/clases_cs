// Clases: Auto y Moto : metodo compartido "conducir"

using System.Drawing;

abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
    public abstract void conducir();
}

class Auto : Vehiculo
{
    public string Patente { get; set; }
    public Auto(string marca, string modelo, string patente): base(marca, modelo) 
    {
        Patente = patente;
    }
    public override void conducir()
    {
        Console.WriteLine($"Conduciendo el auto {Marca} {Modelo} con la patente {Patente}.");
    }
}

class Moto : Vehiculo
{
    public Moto(string marca, string modelo) : base(marca, modelo) { }

    public override void conducir()
    {
        Console.WriteLine($"Conduciendo la moto {Marca} {Modelo}.");
    }
}



class Program
{
    static void Main()
    {
        Vehiculo miAuto = new Auto("Toyota", "Corolla", "123");
        miAuto.conducir();

        Vehiculo miMoto = new Moto("Yamaha", "MT_07");
        miMoto.conducir();
    }
}