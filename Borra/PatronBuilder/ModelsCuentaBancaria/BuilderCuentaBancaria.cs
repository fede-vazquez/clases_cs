namespace PatronBuilder.ModelsCuentaBancaria
{
    public class BuilderCuentaBancaria
    {
        private CuentaBancaria cuentaBancaria;

        public BuilderCuentaBancaria()
        {
            cuentaBancaria = new CuentaBancaria();
        }

        public BuilderCuentaBancaria ConTipoCuenta(string tipoCuenta)
        {
            cuentaBancaria.TipoCuenta = tipoCuenta;
            return this;
        }
        public BuilderCuentaBancaria ConBalanceInicial(double balanceInicial)
        {
            cuentaBancaria.BalanceInicial = balanceInicial;
            return this;
        }
        public BuilderCuentaBancaria ConMoneda(string moneda)
        {
            cuentaBancaria.Moneda = moneda;
            return this;
        }

        public CuentaBancaria Construir()
        {
            return cuentaBancaria;
        }
    }
}
