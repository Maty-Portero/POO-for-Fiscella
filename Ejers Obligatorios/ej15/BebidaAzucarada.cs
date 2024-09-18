using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej15
{
    internal class BebidaAzucarada : Productos
    {
        float azucar;
        bool promo;

        public float Azucar { get { return azucar; } set { azucar = value; } }
        public bool Promo { get { return promo; } set { promo = value; } }


        public BebidaAzucarada(float azucar, bool promo, int id, double litros, double precio, string marca) : base(id, litros, precio, marca)
        {
            this.azucar = azucar;
            this.promo = promo;
        }
    }
}
