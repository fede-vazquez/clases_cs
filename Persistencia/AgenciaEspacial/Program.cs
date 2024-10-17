/*
    La Agencia Espacial Internacional ha decidido crear un sistema para gestionar sus misiones espaciales. En este contexto,
    te han encargado diseñar un programa que permita registrar, modificar, eliminar y visualizar diferentes tipos de misiones.
    Las misiones se dividen en tres tipos: *Exploración*, *Colonización* e *Investigación Científica*.

    Cada misión tiene un nombre, un destino y una cantidad de astronautas asignados. Los destinos pueden ser: Marte, Luna,
    Estación Espacial, un asteroide o Titán. Dependiendo del tipo de misión, la duración estimada será calculada usando
    diferentes fórmulas. Además:
    - Las *misiones de exploración* se centran en recolectar información del destino.
    - Las *misiones de colonización* transportan astronautas y colonos para establecer asentamientos en el destino.
    - Las *misiones de investigación científica* tienen un campo de investigación específico a desarrollar.
    
    El sistema debe incluir un menú interactivo que permita:
    1. *Agregar una nueva misión*, solicitando el nombre, tipo de misión, destino, cantidad de astronautas y otros datos
    específicos según el tipo de misión.
    2. *Mostrar todas las misiones registradas*, mostrando detalles como tipo, destino, astronautas y duración estimada.
    3. *Modificar una misión existente*, permitiendo cambiar cualquier dato relevante.
    4. *Eliminar una misión* por su nombre.
 */
using AgenciaEspacial.Enums;
using AgenciaEspacial.Models;

namespace ViajeEspacial
{
    public class Program
    {
        static void Main()
        {
            GestionMisiones.CargarDatos();
            Menu.MostrarMenu();
        }
    }
}

// tarea: reever los conceptos de callbacks y closure, e investigar muy por encima el patrón estrategy.

// La abstracción es dividir un problema complejo en partes más pequeños.

// llamar una función dentro de otra genera una dependencia, ya que si esa función no existe se rompe todo.
// por eso se utilizan callbacks.
// vamos a manejar el comportamiento de nuestro viaje espacial con Strategy.

/*
    void Saludar(string nombre)
    {
        Console.WriteLine($"Bienvenido {nombre}");
    }
    
    // se puede hacer un closure intermedio para pasar como parámetro.
    Action intermedio = () => Saludar("Juan Perez");
    
    int Sumar(int n1, int n2, Action callback)
    {
        callback();
        return n1 + n2;
    }
    // el () => Saludar("Juan Perez") es una closure, una funsión que retorna otra.
    Console.WriteLine(Sumar(2, 3, () => Saludar("Juan Perez")));
 */