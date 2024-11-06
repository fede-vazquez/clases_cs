namespace PatronBuilder.ModelsPizza
{
    public class PizzaBuilder
    {
        private Pizza pizza;

        public PizzaBuilder()
        {
            pizza = new Pizza();
        }

        public PizzaBuilder ConTamaño(string tamaño)
        {
            pizza.Tamaño = tamaño;
            return this;
        }
        public PizzaBuilder ConBase(string basePizza)
        {
            pizza.Base = basePizza;
            return this;
        }
        public PizzaBuilder ConTipoQueso(string tipoQueso)
        {
            pizza.TipoQueso = tipoQueso;
            return this;
        }
        public PizzaBuilder ConIngredientesAdicionales(string ingrediente)
        {
            pizza.Ingredientes.Add(ingrediente);
            return this;
        }

        public Pizza Construir()
        {
            return pizza;
        }
    }
}
