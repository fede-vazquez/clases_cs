namespace ShoppingCine.Modelos
{
    public class Sala
    {
        public int Numero { get; private set; }
        public List<Asiento> Asientos { get; private set; } = new List<Asiento>();
        public double CostoBase { get; private set; }
        public Sala(int numero, Asiento asiento, double costoBase)
        {
            Numero = numero;
            Asientos.Add(asiento);
            CostoBase = costoBase;
        }
        public Sala(int numero, List<Asiento> asientos, double costoBase)
        {
            Numero = numero;
            Asientos = asientos;
            CostoBase = costoBase;
        }

        public void AgregarAsiento(Asiento asiento) => Asientos.Add(asiento);
        public void AgregarAsiento(List<Asiento> asientos) => Asientos.AddRange(asientos);
        public void ModificarCostoBase(double nuevoCosto) => CostoBase = nuevoCosto;
    }
}