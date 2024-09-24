namespace NotasAlumnos.Models
{
    public class Alumno
    {
        public string Nombre { get; private set; }
        public IDictionary<string, double> Notas { get; private set; } = new Dictionary<string, double>();

        public Alumno(string nombre)
        {
            Nombre = nombre;
        }

        public void ModificarNota(string materia, double nota)
        {
            string materiaMin = materia.ToLower();
            if (Notas.ContainsKey(materiaMin))
            {
                Notas[materiaMin] = nota;
            }
            else
            {
                Notas.Add(materiaMin, nota);
            }
        }

        public void VerNota(string materia)
        {
            Console.WriteLine($"La nota del alumno {Nombre} en la materia {materia} es: {Notas[materia.ToLower()]}");
            Console.WriteLine("\n");
        }

        public void VerNotas()
        {
            Console.WriteLine($"Notas del alumno {Nombre}:");
            foreach (var skn in Notas)
            {
                Console.WriteLine($"{skn.Key}: {skn.Value}");
            }
            Console.WriteLine("\n");
        }
    }
}
