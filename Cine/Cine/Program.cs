using ShoppingCine.Enums;
using ShoppingCine.Modelos;

class Program
{
    static void Main()
    {
        Asiento asiento1 = new Asiento('A', 1, TipoAsiento.Estandar);
        Asiento asiento2 = new Asiento('B', 2, TipoAsiento.Superseat);

        Pelicula LOTR1 = new Pelicula("El señor de los anillos", "Fantasia", 228, Formato._3D_Doblada);

        Sala sala1 = new Sala(1, asiento1, LOTR1, 30, new TimeOnly(7));
        sala1.AgregarAsiento(asiento2);
        sala1.DefinirHorario(new TimeOnly(7, 30));

        Cine cine = new Cine("Show Movies", sala1);

        Entrada entrada1 = new Entrada(cine, sala1, asiento2, DateTime.Now);
        
        sala1.ReproducirPelicula();
    }
}