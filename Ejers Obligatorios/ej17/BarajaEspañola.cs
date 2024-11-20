using ej17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    internal class BarajaEspañola : Baraja 
    { 

        bool cartasExtra;

        public BarajaEspañola (bool cartasExtra, int numTotal, int numXPalo) : base (numTotal,numXPalo)
        {
            this.cartasExtra = cartasExtra;
        }

        public void CartasExtras(bool cartasExtras)
        {
            if (cartasExtras == true)
            {
                NumTotal = 48;
            }
            else
            {
                NumTotal = 40;
            }
        }
    }
}
