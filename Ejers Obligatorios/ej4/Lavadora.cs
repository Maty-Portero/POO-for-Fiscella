using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    internal class Lavadora : Electrodomestico
    {
        double carga = 5;

        public double Carga { get { return carga; } set { carga = value; } }

        public Lavadora() { }

        public Lavadora(double precioBase, double peso) : base (precioBase, peso) { }

        public Lavadora(double precioBase, string color, char consumoEnergetico, double peso, double carga) : base (precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public double GetCarga()
        {
            return Carga;
        }

        public override void PrecioFinal()
        {
            base.PrecioFinal();
            if (Carga > 30)
            {
                PrecioBase += 50;
            }
            else
            {
                PrecioBase += 0;
            }
        }
    }
}
