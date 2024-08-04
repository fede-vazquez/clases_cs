// Televisor, Radio

abstract class DispositivoElectronico
{
    public string Marca { get; set; }

    public DispositivoElectronico(string marca)
    {
        Marca = marca;
    }

    public abstract void Encender();
}

class Televisor : DispositivoElectronico
{
    public Televisor(string marca): base(marca) { }
    public override void Encender()
    {
        Console.WriteLine($"Encendiendo el televisor marca {Marca}");
    }
}

class Radio : DispositivoElectronico
{
    public Radio(string marca): base(marca) { }
    public override void Encender()
    {
        Console.WriteLine($"Encendiendo la radio marca {Marca}");
    }
}
class Program
{
    static void Main()
    {
        DispositivoElectronico miTelevisor = new Televisor("Lenovo");
        miTelevisor.Encender();

        DispositivoElectronico miRadio = new Radio("pichichu");
        miRadio.Encender();
    }
}