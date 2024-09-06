namespace Cine.Modelos
{
    public class Sala
    {
        public int Numero { get; private set; }
        public List<Asiento> Asientos { get; private set; } = new List<Asiento>();
        public Pelicula Pelicula { get; private set; }
        public TimeOnly Horario { get; private set; }

        public Sala(int numero, Asiento asiento, Pelicula pelicula, TimeOnly horario)
        {
            Numero = numero;
            Asientos.Add(asiento);
            Pelicula = pelicula;
            Horario = horario;
        }
        public Sala(int numero, List<Asiento> asientos, Pelicula pelicula, TimeOnly horario)
        {
            Numero = numero;
            Asientos = asientos;
            Pelicula = pelicula;
            Horario = horario;
        }

        //Podrían haber validaciones para que no haya dos asientos iguales.
        public void AgregarAsiento(Asiento asiento) => Asientos.Add(asiento);
        public void AgregarAsiento(List<Asiento> asientos) => Asientos.AddRange(asientos);
        public void DefinirHorario(TimeOnly hora) => Horario = hora;
        public void ReproducirPelicula(Pelicula pelicula) => pelicula.Reproducir();
    }
}