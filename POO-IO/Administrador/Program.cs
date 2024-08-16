using Escuela.Modelos;

namespace Escuela
{
    class Program
    {
        static void Main()
        {
            Modelos.Escuela angelitos = new Modelos.Escuela("Escuela angelitos", new Administrador("Juan Pérez", 15));

            Profesor profe1 = new Profesor("María López");
            profe1.Añadir(new Materia("Matemáticas", 5));
            profe1.Añadir(new Materia("Historia", 3));

            Aula aula1 = new Aula("Aula 1", profe1);
            aula1.Añadir(new Estudiante("Ana", 10));
            aula1.Añadir(new Estudiante("Luis", 11));

            Profesor profe2 = new Profesor("Carglos García");
            profe2.Añadir(new Materia("Ciencias", 4));

            Aula aula2 = new Aula("Aula 2", profe2);
            aula2.Añadir(new Estudiante("Elena", 10));

            angelitos.Añadir(aula1);
            angelitos.Añadir(aula2);

            angelitos.MostrarDetalles();

            Console.WriteLine("\n------------------------------------------------------------------------------------------\n");

            Proyecto proyecto1 = new Proyecto("Proyecto ciencias", "Investigación sobre la energía solar");

            Evaluador evaluador1 = new Evaluador("Sofía Alcaraz", "Matemáticas");

            proyecto1.EvaluarProyecto(evaluador1);
        }
    }
}