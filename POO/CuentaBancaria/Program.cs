class CuentaBancaria
{
    private string _titular;
    private decimal _saldo;

    public CuentaBancaria(string titular, decimal saldoInicial)
    {
        _titular = titular;
        _saldo = saldoInicial;
    }

    public string Titular
    {
        get { return _titular; }
        set { _titular = value; }
    }

    public decimal Saldo
    {
        get { return _saldo; }
        private set { _saldo = value; }
    }

    public void Depositar(decimal cantidad)
    {
        if(cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Depositaste {cantidad}. Saldo actual: {Saldo}.");
        }
        else
        {
            Console.WriteLine("La cantidad a depositar debe ser mayor a 0(cero).");
        }
    }

    public void Retirar(decimal cantidad) {
        if(Saldo - cantidad >= 0)
        {
            Saldo -= cantidad;
            Console.WriteLine($"Retiraste: {cantidad}. Tu saldo actual es: {Saldo}");
        }
        else
        {
            Console.WriteLine($"Intentaste retirar una cantidad mayor a tu saldo actual.");
        }
    }

}

class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria("Ana", 2000);
        cuenta.Depositar(200);
        cuenta.Retirar(150);

        cuenta.Titular = "Pepe";

        // muestra del atributo private
        //cuenta.Saldo = 123456;

        Console.WriteLine($"Saldo final de {cuenta.Titular}: {cuenta.Saldo}");
    }
}