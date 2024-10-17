using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Revolver
    {
        static Random rnd = new Random();
        int posActual = rnd.Next(1, 7);
        static Random rdm = new Random();
        int posBala = rdm.Next(1, 7);

        public int PosActual { get { return posActual; } set { posActual = value; } }
        public int PosBala { get { return posBala; } set { posBala = value; } }

        public Revolver() { }

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
