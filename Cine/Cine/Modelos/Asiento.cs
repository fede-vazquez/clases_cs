using Cine.Enums;

namespace ShoppingCine.Modelos
{
    public class Asiento
    {
        public char Letra { get; private set; }
        public int Numero { get; private set; }
        public TipoAsiento Tipo { get; private set; }
        public bool Ocupado { get; private set; } = false;

        public Asiento(char letra, int numero,  TipoAsiento tipo)
        {
            Letra = letra;
            Numero = numero;
            Tipo = tipo;
        }

        public void CambiarOcupado() => Ocupado = !Ocupado;
    }
}
