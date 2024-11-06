namespace VehiculoPatronBuilder.Models
{
    public class CocheBuilder : IVehiculoBuilder
    {
        private Vehiculo vehiculo = new Vehiculo { Tipo = "Camion" };
        public void ConfigurarMotor() => vehiculo.Motor = "Motor diesel 5.0L";

        public void ConfigurarPuertas() => vehiculo.Puertas = 2;

        public void ConfigurarTieneRemolque() => vehiculo.TieneRemolque = true;
        public Vehiculo Construir() => vehiculo;
    }
}