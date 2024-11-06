namespace VehiculoPatronBuilder.Models
{
    public class CamionBuilder : IVehiculoBuilder
    {
        private Vehiculo vehiculo = new Vehiculo { Tipo = "Coche" };
        public void ConfigurarMotor() => vehiculo.Motor = "Motor gasolina 1.6L";

        public void ConfigurarPuertas() => vehiculo.Puertas = 4;

        public void ConfigurarTieneRemolque() => vehiculo.TieneRemolque = false;
        public Vehiculo Construir() => vehiculo;
    }
}
