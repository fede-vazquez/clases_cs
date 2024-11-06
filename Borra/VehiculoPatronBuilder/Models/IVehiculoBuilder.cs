namespace VehiculoPatronBuilder.Models
{
    public interface IVehiculoBuilder
    {
        void ConfigurarMotor();
        void ConfigurarPuertas();
        void ConfigurarTieneRemolque();
        Vehiculo Construir();
    }
}
