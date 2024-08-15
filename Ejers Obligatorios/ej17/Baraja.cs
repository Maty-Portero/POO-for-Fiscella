using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    abstract class Baraja : Carta
    {
        int numTotal;
        int numXpalo;

        public int NumTotal { get { return numTotal; } set { numTotal = value;  } }
        public int NumXpalo { get { return numXpalo; } set { numXpalo = value; } }

        public void crearBaraja()
        {
            
        }

        
    }
}
