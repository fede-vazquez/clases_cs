// Clase intermedia, una capa más de abstracción
using System.Threading.Channels;

namespace ListaDeTareas.Models
{
    public static class Sistema
    {
        // Por defecto el static es privado, hay que colocarle el public para que nos deje acceder desde otro lugar.
        static Dictionary<string, Usuario> usuarios = new();

        // Archivos donde van a persistir los datos
        static readonly string archivo = "usuarios.txt";
        // Guardamos el formato por el que vamos a separar los usuarios.
        static readonly string usuarioSeparador = "-";

        public static void AgregarUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            // Algo importante antes de agregar algo a un diccionario es validar si existe o no.
            if (!usuarios.ContainsKey(nombreUsuario))
            {
                usuarios[nombreUsuario] = new Usuario(nombreUsuario);
                Console.WriteLine($"Usuario {nombreUsuario} agregado");
            }
            else
            {
                Console.WriteLine("Usuario existente");
            }
        }

        public static void AgregarTareaAUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if(usuarios.ContainsKey(nombreUsuario))
            {
                Console.Write("Ingrese la descripción de la tarea: ");
                string descripcionTarea = Console.ReadLine();

                Tarea tarea = new Tarea(descripcionTarea);
                usuarios[nombreUsuario].AgregarTareas(tarea);
            }
            else
            {
                Console.WriteLine("El usuario no existe.");
            }
        }

        public static void CambiarEstadoTareaDeUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                Console.Write("Ingrese el número de la tarea a cambiar (empezando desde 0): ");
                int indice = int.Parse(Console.ReadLine());

                usuarios[nombreUsuario].CambiarEstadoTarea(indice);
                Console.WriteLine("Estado de la tarea cambiado.");
            }
            else
            {
                Console.WriteLine("El usuario no existe.");
            }
        }

        public static void MostrarTareasDeUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                usuarios[nombreUsuario].MostrarTareas();
            }
            else
            {
                Console.WriteLine("El usuario no existe.");
            }
        }

        public static void GuardarDatos()
        {
            // Es importante abrir y cerrar la conección con los archivos.
            // Utilizando un using lo hace automaticamente.
            // Todo dentro de las llaves es lo que utiliza el archivo.
            using (StreamWriter writer = new StreamWriter(archivo))
            {
                foreach(var usuario in usuarios)
                {
                    writer.WriteLine(usuario.Key);
                    foreach (var tarea in usuario.Value.Tareas)
                    {
                        writer.WriteLine($"{tarea.Descripcion}|{tarea.IsCompletada}");
                    }
                }
                writer.WriteLine(usuarioSeparador);
            }
            Console.WriteLine("Datos guardados correctamente.");
        }

        public static void CargarDatos()
        {
            if (File.Exists(archivo))
            {
                using StreamReader reader = new StreamReader(archivo);

                string linea;

                // El null en este caso nos sirve para tener la plantilla de usuario.
                Usuario usuarioActual = null;

                // Hay que parar de leer el archivo cuando no haya nada nada escrito en una linea.
                while ((linea = reader.ReadLine()) != null)
                {
                    // Si la linea tiene un separador de usuario significa que ya terminamos de leer el usuario actual.
                    if(linea == usuarioSeparador)
                    {
                        usuarioActual = null; // Fin de un usuario
                    }
                    else if(usuarioActual == null)
                    {
                        usuarioActual = new Usuario(linea);
                        usuarios[linea] = usuarioActual;
                    }
                    else
                    {
                        // Aca va a entrar siempre que usuario no sea null, es decir que estemos leyendo sus tareas.
                        string[] partes = linea.Split("|");
                        string descripcion = partes[0];
                        bool completada = bool.Parse(partes[1]);

                        var tarea = new Tarea(descripcion, completada);
                        usuarioActual.AgregarTareas(tarea);
                    }
                }
            }
            else
            {
                Console.WriteLine("Datos no encontrados");
            }
            Console.WriteLine("Datos cargados correctamente.");
        }
    }
}
