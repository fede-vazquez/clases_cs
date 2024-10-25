namespace Constructores_Destructores.Models
{
    public class ConexionBaseDatos
    {
        // Para simular la conexión...
        private bool conexionAbierta;
        private string archivo = "../../../test.txt";

        public ConexionBaseDatos()
        {
            conexionAbierta = false;
            Console.WriteLine("Conexión a la base de datos creada.");

            using StreamWriter writer = new StreamWriter(archivo, true);
            writer.WriteLine("Conexión a la base de datos creada.");
        }

        public void AbrirConexion()
        {
            if (!conexionAbierta)
            {
                conexionAbierta = true;
                Console.WriteLine("Conexión a la base de datos abierta.");
            }
            else
            {
                Console.WriteLine("La conexión ya está abierta.");
            }
        }

        public void CerrarConexion()
        {
            if (conexionAbierta)
            {
                conexionAbierta = false;
                Console.WriteLine("Conexión a la base de datos cerrada.");
            }
            else
            {
                Console.WriteLine("La conexión ya está cerrada.");
            }
        }

        // La virgurilla dice que es un destructor.
        ~ConexionBaseDatos()
        {
            if (conexionAbierta)
            {
                conexionAbierta = false;
                Console.WriteLine("Destructor llamado: Conexión cerrada automáticamente.");

                using StreamWriter writer = new StreamWriter(archivo, true);
                writer.WriteLine("La conexiòn se cerro automáticamente.");
            }
        }
    }
}
