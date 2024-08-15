using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    internal class Television : Electrodomestico
    {
        int resolucion = 20;
        bool sintetizadorTDT = false;

        public int Resolucion { get { return resolucion; } set { resolucion = value; } }
        public bool SintetizadorTDT { get { return sintetizadorTDT; } set { sintetizadorTDT = value; } }

        public Television() { }

        public Television(double precioBase, double peso) : base(precioBase, peso) { }

        public Television(double precioBase, string color, char consumoEnergetico, double peso, int resolucion, bool sintetizadorTDT) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintetizadorTDT = sintetizadorTDT;
        }

        public int GetResolucion()
        {
            return Resolucion;
        }

        public bool GetSintetizadorTDT()
        {
            return SintetizadorTDT;
        }

        public override double PrecioFinal()
        {
            base.PrecioFinal();
            if (Resolucion > 40)
            {
                if (SintetizadorTDT == true)
                {
                    return PrecioBase + 50;
                }
                return PrecioBase + (PrecioBase * 30) / 100;
            }
            return 0;
        }
    }
}
