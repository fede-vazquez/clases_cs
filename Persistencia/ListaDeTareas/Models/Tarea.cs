namespace ListaDeTareas.Models
{
    public class Tarea
    {
        public string Descripcion { get; set; }
        public bool IsCompletada { get; set; }

        // bool completada = false. Da un valor por default al atributo completada.
        // bool? completada. Hace que el atributo sea opcional, en este caso no se usa.
        public Tarea(string descripcion, bool completada = false)
        {
            Descripcion = descripcion;
            IsCompletada = completada;
        }

        // Todas las clases tienen el método ToString().
        public override string ToString()
        {
            // Las ternarias en los $"" van entre ().
            return $"{Descripcion} - {(IsCompletada ? "Completada" : "Pendiente")}.";
        }
    }
}