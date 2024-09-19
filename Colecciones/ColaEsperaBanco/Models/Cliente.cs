namespace ColaEsperaBanco.Models
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int NumeroCliente { get; set; }

        public Cliente(string nombre, int numeroCliente)
        {
            Nombre = nombre;
            NumeroCliente = numeroCliente;
        }
    }
}
