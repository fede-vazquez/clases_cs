namespace PatronBuilder.ModelsCuentaBancaria
{
    public class CuentaBancaria
    {
        public string TipoCuenta { get; set; }
        public double BalanceInicial { get; set; }
        public string Moneda { get; set; }

        public override string ToString()
        {
            return $"Cuenta: [TipoCuenta: {TipoCuenta}, BalanceInicial: {BalanceInicial}, Moneda: {Moneda}]";
        }
    }
}
