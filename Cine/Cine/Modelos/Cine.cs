namespace ShoppingCine.Modelos
{
    public class Cine
    {
        public string Nombre { get; private set; }
        public List<Sala> Salas { get; private set; } = new List<Sala>();
        
        public Cine(string nombre, Sala sala)
        {
            Nombre = nombre;
            Salas.Add(sala);
        }
        public Cine(string nombre, List<Sala> salas)
        {
            Nombre = nombre;
            Salas.AddRange(salas);
        }

        public void AgregarSala(Sala sala) => Salas.Add(sala);
    }
}