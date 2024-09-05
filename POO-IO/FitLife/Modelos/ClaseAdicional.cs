namespace FitLife.Modelos
{
    public class ClaseAdicional
    {
        private string _nombre;
        private double _costo;

        public ClaseAdicional(string nombre, double costo)
        {
            _nombre = nombre;
            _costo = costo;
        }

        public string Nombre => _nombre;
        public double Costo => _costo;
    }
}
