namespace ListaDeTareas.Models
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public List<Tarea> Tareas { get; private set; } = new List<Tarea>();

        public Usuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }

        public void AgregarTareas(Tarea tarea) => Tareas.Add(tarea);

        public void MostrarTareas()
        {
            Console.WriteLine($"\nTareas de {NombreUsuario}:");
            if(Tareas.Count > 0)
            {
                foreach (var tarea in Tareas)
                {
                    // Usamos el método ToString que sobreescribimos.
                    // Si no le ponemos el .ToString() la consola lo utiliza automaticamente.
                    Console.WriteLine(tarea);
                }
            }
            else
            {
                Console.WriteLine("No hay tareas aún.");
            }
        }

        public void CambiarEstadoTarea(int indice)
        {
            if(indice >= 0 && indice < Tareas.Count)
            {
                Tareas[indice].IsCompletada = !Tareas[indice].IsCompletada;
            }
            else
            {
                Console.WriteLine(new IndexOutOfRangeException().Message);
            }
        } 
    }
}
