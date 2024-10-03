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


<<<<<<< HEAD
        public BebidaAzucarada(string origen, int id, double litros, double precio, string marca) : base (id, litros, precio, marca)
=======
        public BebidaAzucarada(float azucar, bool promo, int id, double litros, double precio, string marca) : base(id, litros, precio, marca)
>>>>>>> 430fe4902fd1d86a674188b0e1b9f34ed2ab69d6
        {
            this.azucar = azucar;
            this.promo = promo;
        }
    }
}
