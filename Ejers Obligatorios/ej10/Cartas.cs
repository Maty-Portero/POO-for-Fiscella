using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Cartas
    {
        int numero;
        string palo;
        int cantCartas = 40;

        public int Numero { get { return numero; } set { numero = value; } }
        public string Palo { get { return palo; } set { palo = value; } }

        public Cartas(int numero, string palo) 
        {
            this.numero = numero;
            this.palo = palo;
        }

        public void Barajar()
        {

        }
        
    }
}
