namespace AgenciaEspacial.Models
{
    public static class GestionMisiones
    {
        public static List<Mision> Misiones { get; private set; } = new List<Mision>();
        public static string archivoMisiones {  get; private set; }

        public static void AgregarMision(Mision mision) => Misiones.Add(mision);

        public static void MostrarMisiones()
        {
            if(Misiones.Count > 0)
            {
                foreach(var m in Misiones)
                {
                    Console.WriteLine(m);
                }
            }
        }

        public static void ModificarMision(string nombre, Mision nuevaMision)
        {
            if (EliminarMision(nombre)) AgregarMision(nuevaMision);
        }

        public static bool EliminarMision(string nombre)
        {
            Mision m = Misiones.Find(m => m.Nombre == nombre);
            return Misiones.Remove(m);
        }
    }
}
