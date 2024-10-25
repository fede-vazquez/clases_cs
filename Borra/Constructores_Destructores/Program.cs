using Constructores_Destructores.Models;

public class Program
{
    static void Main()
    {
        ConexionBaseDatos conexion = new ConexionBaseDatos();

        conexion.AbrirConexion();

        // ... hacemos algo ...

        // Al finalizar el programa o salir del alcance del objeto
        // el destructor será llamado.
        // En este caso no se vé, ya que estamos en la consola. Se vería si usaramos persistencia,
        // donde guardemos la ejecución del destructor
    }
}