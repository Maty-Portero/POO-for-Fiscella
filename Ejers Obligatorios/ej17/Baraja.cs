using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    abstract class Baraja
    {
        int numTotal;
        int numXPalo;

        public int NumTotal {  get { return numTotal; } set { numTotal = value; } }
        public int NumXPalo{  get { return numXPalo; } set { numXPalo = value; } }

        public Baraja(int numTotal, int numXPalo) 
        {
            this.numTotal = numTotal;
            this.numXPalo = numXPalo;
        }

        //abstract void crearBaraja()
        //{
        //}
    }
}
