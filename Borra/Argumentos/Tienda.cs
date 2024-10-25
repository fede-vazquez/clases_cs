namespace Argumentos
{
    public class Tienda
    {
        // Método que calcula el costo total sin modificar el precio original. (por valor)
        // Parecido a una dependencia
        public void CalcularCostoTotal(int cantidad, double precioUnitario)
        {
            double costoTotal = cantidad * precioUnitario;
            Console.WriteLine($"Costo total (sin modificar el precio): {costoTotal:C}");
        }


        // Método que despacha un pedido y actualiza el stock (por referencia)
        // para decirle que un parámetro es de referencia hay que colocarle "ref"
        public void DespacharProducto(ref int stock, int cantidadPedida)
        {
            stock -= cantidadPedida;
            Console.WriteLine($"Stock actualizado: {stock} unidades restantes.");
        }


        // Método que utiliza un argumento de entrada para asegurar que no se modifica (argumento "in").
        // le agregamos in al comienzo para que no se pueda modificar, solo entrar.
        public void MostrarPrecioUnitario(in double precioUnitario)
        {
            Console.WriteLine($"El precio por unidad es: {precioUnitario:C} (No puede modificarse)");
        }


        // Método que utiliza un argumento de salida para devolver cuantasunidades no fueron despachadas. (out)
        // Le ponemos un out antes de definir su tipo.
        public void CalcularUnidadesFaltantes(int stockDisponible, int cantidadPedida, out int unidadesFaltantes)
        {
            if( stockDisponible >= cantidadPedida)
            {
                unidadesFaltantes = 0;
            }
            else
            {
                unidadesFaltantes = cantidadPedida - stockDisponible;
            }
        }
    }
}
