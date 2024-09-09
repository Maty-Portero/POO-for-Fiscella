using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej15
{
    internal class BebidaAzucarada
    {
        string origen;

        public string Origen { get { return origen; } set { origen = value; } }


        public BebidaAzucarada(string origen, int id, double litros, double precio, string marca) : base(id, litros, precio, marca)
        {
            this.origen = origen;
        }
    }
}
