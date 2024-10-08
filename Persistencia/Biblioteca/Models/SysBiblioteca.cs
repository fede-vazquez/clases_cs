namespace Biblioteca.Models
{
    public static class SysBiblioteca
    {
        public static List<Libro> Libros = new();
        public static List<Usuario> Usuarios = new();
        static readonly string ArchivoUsuarios = "Usuario.txt";
        static readonly string ArchivoLibros = "Libros.txt";

        public static List<Libro>ObtenerLibros() => Libros;
        public static List<Usuario> ObtenerUsuarios() => Usuarios;

        public static void AgregarLibro(Libro libro) => Libros.Add(libro);
        public static void AgregarUsuario(Usuario usuario) => Usuarios.Add(usuario);

        public static void RealizarPrestamo(Libro libro, Usuario usuario)
        {
            if(libro.EjemplaresDisponibles >= 1)
            {
                Prestamo prestamito = new Prestamo(libro, DateTime.Now);
                libro.QuitarEjemplar();
                usuario.AgregarPrestamo(prestamito);
                Console.WriteLine("Prestamo realizado con éxito");
            }
            else
            {
                Console.WriteLine("La cantidad de ejemplares disponibles no es suficíente.");
            }
        }

        public static void RealizarDevolucion(Libro libro, Usuario usuario)
        {
            Prestamo prestamo = usuario.Prestamos.Find((p) => p.Libro == libro);

            if(prestamo != null)
            {
                usuario.QuitarPrestamo(prestamo);
                libro.AgregarEjemplar();
                Console.WriteLine($"Libro '{libro.Titulo}' devuelto.");
            }
            else
            {
                Console.WriteLine($"El usuario {usuario.Nombre} no realizó el prestamo del libro {libro.Titulo}");
            }
        }

        public static void GuardarDatos()
        {
            using StreamWriter writerLibro = new StreamWriter(ArchivoLibros);

            foreach (var libro in Libros)
            {
                writerLibro.WriteLine(libro);
            }

            using StreamWriter writerUsuario = new StreamWriter(ArchivoUsuarios);

            foreach (var usuario in Usuarios)
            {
                writerUsuario.WriteLine(usuario.Nombre);

                foreach (var prestamo in usuario.Prestamos)
                {
                    writerUsuario.WriteLine(prestamo);
                }
                writerUsuario.WriteLine("+");
            }
        }

        public static void CargarDatos()
        {
            if (File.Exists(ArchivoLibros))
            {
                // File.ReadAllLines(nombreArchivo) devuelve un array de strings con cada linea del archivo.
                foreach (var line in File.ReadAllLines(ArchivoLibros))
                {
                    var d = line.Split(';');
                    var libro = new Libro(d[0], d[1], d[2], int.Parse(d[3]));
                    Libros.Add(libro);
                }

                using StreamReader reader = new StreamReader(ArchivoUsuarios);
                string linea;
                Usuario u = null;

                while ((linea = reader.ReadLine()) != null)
                {
                    if(linea == "+")
                    {
                        u = null;
                    }else if(u == null)
                    {
                        u = new Usuario(linea);
                    }
                    else
                    {
                        var pd = linea.Split(";");
                        var libro = Libros.Find(l => l.Codigo == pd[0]);
                        if(libro != null)
                        {
                            var prestamo = new Prestamo(libro, DateTime.Parse(pd[1]));
                            u.AgregarPrestamo(prestamo);
                        }
                    }
                }
            }
        }   

    }
}

// ejercicio: try catch si no se pone ninguna opción y se pone enter, capturamos el error y se lo mandamos por consola al usuario con Exception
// mostrar usuaris y libros.