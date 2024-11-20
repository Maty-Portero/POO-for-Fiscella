using System;
using static ej17.Carta;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    internal class BarajaFrancesa : Baraja
    {
        public BarajaFrancesa(int numTotal, int numXPalo) : base(numTotal, numXPalo) { }

        public void AseignarCartas()
        {
            NumTotal = 52;
            NumXPalo = 13;
        }

        public string ObtenerCarta(CartaGenerico<PalosBarFrancesa> francesa, CartaGenerico<PalosBarEspañola> española)
        {
            if (francesa.Palo == PalosBarFrancesa.trebol || francesa.Palo == PalosBarFrancesa.diamante || francesa.Palo == PalosBarFrancesa.corazon || francesa.Palo == PalosBarFrancesa.pica)
            {
                switch (francesa.Valor)
                {
                    case 1: return "As";
                    case 11: return "Jota";
                    case 12: return "Reina";
                    case 13: return "Rey";
                    default: return francesa.Valor.ToString();
                }
            }else if (española.Palo == PalosBarEspañola.oro || española.Palo == PalosBarEspañola.copa || española.Palo == PalosBarEspañola.espada || española.Palo == PalosBarEspañola.bastos)
            {
                switch (española.Valor)
                {
                    case 1: return "As";
                    case 11: return "Sota";
                    case 12: return "Caballo";
                    case 13: return "Rey";
                    default: return española.Valor.ToString();
                }
            }else
                return "Carta no valida";
        }

        public bool cartaRoja(CartaGenerico<PalosBarFrancesa> francesa)
        {
            if (francesa.Palo == PalosBarFrancesa.corazon || francesa.Palo == PalosBarFrancesa.diamante)
            {
                return true;
            }
            else 
                return false;
        }

        public bool cartaNegra(CartaGenerico<PalosBarFrancesa> francesa)
        {
            if (francesa.Palo == PalosBarFrancesa.corazon || francesa.Palo == PalosBarFrancesa.diamante)
            {
                return false;
            }
            else 
                return true;
        }
    }
}
