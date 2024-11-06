namespace VehiculoPatronBuilder.Models
{
    public class Vehiculo
    {
        public string Tipo { get; set; }
        public string Motor { get; set; }
        public int Puertas { get; set; }
        public bool TieneRemolque { get; set; }

        public override string ToString()
        {
            //(TieneRemolque ? "si": "no")
            return $"Vehículo: [Tipo: {Tipo}, Motor: {Motor}, Numero de puertas: {Puertas}, Tiene remolque: {TieneRemolque}]";
        }
    }
}
