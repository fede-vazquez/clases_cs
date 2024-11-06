namespace ReportePatronBuilder.Models
{
    public class Reporte
    {
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string Formato { get; set; }

        public override string ToString()
        {
            return $"Reporte: [Titulo: {Titulo}, Contenido: {Contenido}, Formato: {Formato}]";
        }
    }
}
