using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    internal class Carta
    {
        PalosBarFrancesa paloFra;
        PalosBarEspañola paloEsp;

        bool esCartaRoja = false;
        bool esCartaNegra = false;

        public bool EsCartaNegra { get { return esCartaNegra; } set { esCartaNegra = value;  } }
        public bool EsCartaRoja { get { return esCartaRoja; } set { esCartaRoja = value; } }

        enum PalosBarEspañola { Oros, Copas, Espadas, Bastos}
        enum PalosBarFrancesa { Diamantes, Picas, Corazones, Treboles}

        public void cartaRoja()
        {
            if (paloFra == PalosBarFrancesa.Corazones || paloFra == PalosBarFrancesa.Diamantes)
            {
                EsCartaRoja = true;
            }
        }

        public void cartaNegra()
        {
            if (paloFra == PalosBarFrancesa.Treboles || paloFra == PalosBarFrancesa.Picas)
            {
                EsCartaNegra = true;
            }
        }

        public void barFrancesa()
        {
            
        }

        public void barEspañola()
        {

        }
    }
}
