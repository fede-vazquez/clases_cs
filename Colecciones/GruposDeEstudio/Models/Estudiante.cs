namespace GruposDeEstudio.Models
{
    public class Estudiante
    {
        public string Nombre { get; private set; }
        public List<string> Materias { get; private set; } = new List<string>();

        public Estudiante(string nombre,  List<string> materias)
        {
            Nombre = nombre;
            Materias = materias;
        }
    }
}
