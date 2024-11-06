namespace ReportePatronBuilder.Models
{
    public class ReportePDFBuilder : IReporteBuilder
    {
        Reporte reporte = new Reporte { Formato = "PDF" };
        public void ConfigurarContenido() => reporte.Contenido = "Números, muchos";
        public void ConfigurarTitulo() => reporte.Titulo = "Reporte de contabilidad";
        public Reporte ObtenerReporte() => reporte;
    }
}
