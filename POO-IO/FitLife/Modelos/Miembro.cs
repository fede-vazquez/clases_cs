using FitLife.Enums;

namespace FitLife.Modelos
{
    public class Miembro
    {
        public string Nombre { get; private set; }
        public TipoMembresia Membresia { get; private set; }
        public double CostoBaseMembresia
        { get
            {
                switch (Membresia)
                {
                    case TipoMembresia.Basico:
                        return 30;
                    case TipoMembresia.Premium:
                        return 50;
                    case TipoMembresia.VIP:
                        return 80;
                    default:
                        return 0;
                }
            }
        }
        public List<ClaseAdicional> ClasesAdicionales { get; private set; } = new List<ClaseAdicional>();
        public bool AccesoPiscina => (Membresia == TipoMembresia.Premium || Membresia == TipoMembresia.VIP);
        public bool AccesoSpa => Membresia == TipoMembresia.VIP;
        public bool AccesoClasesGrupales => Membresia != TipoMembresia.Basico;

        public double DescuentoEnClases
        {
            get
            {
                if (Membresia == TipoMembresia.Premium) return 0.1;
                if (Membresia == TipoMembresia.VIP) return 0.2;
                return 0;
            }
        }
        public double CostoTotalClases
        {
            get
            {
                double costoTotal = 0;
                foreach (var clase in ClasesAdicionales)
                {
                    costoTotal += clase.Costo * (1 - DescuentoEnClases);
                }
                return costoTotal;
            }
        }
        public double CostoMensualTotal => CostoBaseMembresia + CostoTotalClases;

        public Miembro(string nombre, TipoMembresia membresia)
        {
            Nombre = nombre;    
            Membresia = membresia;
        }

        public void MostrarDetallesMembresia()
        {
            Console.WriteLine("Detalles de la Membresia:");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Membresia: {Membresia}");
            Console.WriteLine($"Acceso a Piscina: {(AccesoPiscina ? "Si" : "No")}");
            Console.WriteLine($"Acceso a Spa: {(AccesoSpa ? "Si" : "No")}");
            Console.WriteLine($"Clases Grupales: {(AccesoClasesGrupales ? "Si" : "No")}");
            Console.WriteLine($"Costo Base Membresia: {CostoBaseMembresia:C}\n");

            Console.WriteLine("- Clases Adicionales:\n");
            foreach (var clase in ClasesAdicionales)
            {
                Console.WriteLine($" ° Nombre Clase: {clase.Nombre}");
                Console.WriteLine($" ° Costo Clase: {clase.Costo:C}");
                Console.WriteLine($" ° Descuento aplicado: {DescuentoEnClases * 100}%\n");
            }
            Console.WriteLine($"Costo Total Clases adicionales: {CostoTotalClases:C}\n");

            Console.WriteLine($"Costo Total Membresia + Clases: {CostoMensualTotal:C}");
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}