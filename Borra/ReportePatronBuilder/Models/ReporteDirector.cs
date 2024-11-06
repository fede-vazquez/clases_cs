namespace ReportePatronBuilder.Models
{
    public class ReporteDirector
    {
        private IReporteBuilder _reporteBuilder;

        public ReporteDirector(IReporteBuilder reporteBuilder)
        {
            _reporteBuilder = reporteBuilder;
        }

        public Reporte Construir()
        {
            _reporteBuilder.ConfigurarTitulo();
            _reporteBuilder.ConfigurarContenido();

            return _reporteBuilder.ObtenerReporte();
        }
    }
}
