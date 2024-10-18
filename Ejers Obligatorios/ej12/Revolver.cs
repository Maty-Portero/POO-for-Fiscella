using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Revolver
    {
        int posActual;
        int posBala;

        public int PosActual { get { return posActual; } set { posActual = value; } }
        public int PosBala { get { return posBala; } set { posBala = value; } }

        public Revolver(int posActual, int posBala) 
        {
            this.posActual = posActual;
            this.posBala = posBala;
        }

        public bool disparar()
        {
            if (posBala == posActual)
            {
                return true;
            }
            return false;
        }

        public void siguienteBala()
        {
            if (posBala == 7)
            {
                posBala = 1;
            }
            else
            {
                posBala++;
            }
        }
    }
}
