using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    internal class Carta
    {
        public enum PalosBarEspañola { oro, copa, espada, bastos};
        public enum PalosBarFrancesa { diamante, pica, corazon, trebol};

        public class CartaGenerico<T>
        {
            T palo;
            int valor;

            public T Palo { get { return palo; } set { palo = value; } }
            public int Valor { get { return valor; } set { valor = value; } }

            public CartaGenerico(T palo, int valor)
            {
                this.palo = palo;
                this.valor = valor;
            }

        }
    }
}
