namespace PatronBuilder.ModelsPizza
{
    public class Pizza
    {
        public string Tamaño { get; set; }
        public string Base { get; set; }
        public string TipoQueso { get; set; }
        public List<string> Ingredientes { get; set; } = new ();

        public override string ToString()
        {
            return $"Pizza: [Tamaño: {Tamaño}, Base: {Base}, TipoQueso: {TipoQueso}, IngredientesAdicionales: {string.Join(", ", Ingredientes)}]";
        }
    }
}
