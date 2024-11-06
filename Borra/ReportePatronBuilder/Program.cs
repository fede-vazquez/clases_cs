using ReportePatronBuilder.Models;

namespace ReportePatronBuilder
{
    public class Program
    {
        static void Main()
        {
            ReporteDirector director = new ReporteDirector(new ReporteTextoBuilder());
            Reporte reporteTexto = director.Construir();
            Console.WriteLine(reporteTexto);

            director = new ReporteDirector(new ReportePDFBuilder());
            Reporte reportePDF = director.Construir();
            Console.WriteLine(reportePDF);
        }
    }
}