namespace ReportePatronBuilder.Models
{
    public class ReporteTextoBuilder : IReporteBuilder
    {
        Reporte reporte = new Reporte { Formato = "Texto"};
        public void ConfigurarContenido() => reporte.Contenido = "Texto mucho texto.";
        public void ConfigurarTitulo() => reporte.Titulo = "Reporte de ventas";
        public Reporte ObtenerReporte() => reporte;
    }
}