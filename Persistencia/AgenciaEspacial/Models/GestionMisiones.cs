namespace AgenciaEspacial.Models
{
    public static class GestionMisiones
    {
        public static List<Mision> Misiones { get; private set; } = new List<Mision>();

        public static void AgregarMision(Mision mision)
        {
            Misiones.Add(mision);
            SysArchivo.GuardarMision(mision);
            Console.WriteLine($"Misión '{mision.Nombre}' agregada con exito.");
        }

        public static void MostrarMisiones()
        {
            if (Misiones.Count > 0)
            {
                Console.WriteLine("Misiones:");
                foreach(var m in Misiones)
                {
                    Console.WriteLine(m);
                }
            }
            else
            {
                Console.WriteLine("No hay misiones para mostrar.");
            }
        }

        public static void ModificarMision(string nombre, Mision nuevaMision)
        {
            //if (EliminarMision(nombre)) AgregarMision(nuevaMision);
            var mision = Misiones.Find(m => m.Nombre == nombre);

            if(mision == null )
            {
                Console.WriteLine($"Misión '{nombre}' no encontrada.");
            }
            else
            {
                Misiones.Remove(mision);
                Misiones.Add(nuevaMision);
                Console.WriteLine($"Misión '{nombre}' ha sido modificada");
            }
        }

        public static void EliminarMision(string nombre)
        {
            var m = Misiones.Find(m => m.Nombre == nombre);

            if(m == null)
            {
                Console.WriteLine($"Misión '{nombre}' no encontrada.");
            }
            else
            {
                Misiones.Remove(m);
                Console.WriteLine($"Misión '{nombre}' ha sido eliminada");
            }
        }


        public static void GuardarDatos() => SysArchivo.GuardarDatos(Misiones);
    }
}

// Programación imperativa: se escribe el cómo se hacen las cosas.
// Programación declarativa: se escribe que se tiene que hacer.