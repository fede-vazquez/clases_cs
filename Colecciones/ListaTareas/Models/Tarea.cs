namespace ListaTareas.Models
{
    public class Tarea
    {
        public string Descripcion { get; private set; }
        public bool IsCompletada { get; private set; }

        public Tarea(string descripcion)
        {
            Descripcion = descripcion;
        }

        public void CompletarTarea() => IsCompletada = true;
    }
}
