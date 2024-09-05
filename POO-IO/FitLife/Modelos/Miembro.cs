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
        public List<ClaseAdicional> ClasesAdicional { get; private set; } = new List<ClaseAdicional>();
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
                foreach (var clase in ClasesAdicional)
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
    }
}