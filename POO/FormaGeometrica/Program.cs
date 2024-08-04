abstract class FormaGeometrica
{
    public abstract double CalcularArea();
}

class Rectangulo : FormaGeometrica
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public Rectangulo(double largo, double ancho)
    { 
        Largo = largo;
        Ancho = ancho;
    }

    public override double CalcularArea()
    {
        return Largo * Ancho;
    }
}

class Circulo : FormaGeometrica
{
    public double Radio { get; set; }

    public Circulo(double radio) 
    {
        Radio = radio;
    }
    public override double CalcularArea() 
    {
        return Math.PI * (Radio * Radio);
    }
}

class Program
{
    static void Main()
    {
        FormaGeometrica rectangulo = new Rectangulo(4, 6);
        FormaGeometrica circulo = new Circulo(5);

        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}cm");
        Console.WriteLine($"Área del circulo: {circulo.CalcularArea()}cm");
    }
}