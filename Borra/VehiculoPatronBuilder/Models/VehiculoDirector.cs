namespace VehiculoPatronBuilder.Models
{
    // Aca se aplica el patrón de inyección de dependencia.
    public class VehiculoDirector
    {
        private IVehiculoBuilder _builder;

        public VehiculoDirector(IVehiculoBuilder builder)
        {
            _builder = builder;
        }

        public Vehiculo Construir()
        {
            _builder.ConfigurarMotor();
            _builder.ConfigurarPuertas();
            _builder.ConfigurarTieneRemolque();
            return _builder.Construir();
        }
    }
}
