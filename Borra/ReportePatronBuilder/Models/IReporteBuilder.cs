namespace ReportePatronBuilder.Models
{
    public interface IReporteBuilder
    {
        void ConfigurarTitulo();
        void ConfigurarContenido();
        Reporte ObtenerReporte();
    }
}
