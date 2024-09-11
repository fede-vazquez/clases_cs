namespace Cinema.Models
{
    public class Sala
    {
        public int Numero { get; private set; }
        public List<Asiento> Asientos { get; private set;} = new List<Asiento>();
        public Pelicula? Pelicula { get; private set; }
        public DateTime Horario { get; private set; }

        public Sala(int numero)
        {
            Numero = numero;
        }
        public Sala(int numero, List<Asiento> asientos)
        {
            Numero = numero;
            Asientos = asientos;
        }

        public void AgregarAsiento(Asiento asiento) => Asientos.Add(asiento);
        public void AgregarAsiento(List<Asiento> asientos) => Asientos.AddRange(asientos);
        public void DefinirHorario(DateTime horario) => Horario = horario;
        public void ReproducirPelicula(Pelicula pelicula) => Pelicula = pelicula;
    }
}
