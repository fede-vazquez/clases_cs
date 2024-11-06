using PatronBuilder.ModelsCuentaBancaria;
using PatronBuilder.ModelsPizza;

namespace PatronBuilder
{
    public class Program
    {
        static void Main()
        {
            // prueba con pizza
            PizzaBuilder builderPizza = new PizzaBuilder();

            Pizza pizza = builderPizza
                .ConTamaño("Grande")
                .ConBase("Delgada")
                .ConIngredientesAdicionales("Pepperoni")
                .ConIngredientesAdicionales("Aceitunas")
                .ConTipoQueso("Mozzarella")
                .Construir();

            // Console.WriteLine(pizza);

            // -----------------------------------------------------

            // prueba con cuenta bancaria

            BuilderCuentaBancaria builderCtaBancaria = new BuilderCuentaBancaria();

            CuentaBancaria cta = builderCtaBancaria
                .ConTipoCuenta("Corriente")
                .ConBalanceInicial(0)
                .ConMoneda("Pesos")
                .Construir();

            Console.WriteLine(cta);
        }
    }
}