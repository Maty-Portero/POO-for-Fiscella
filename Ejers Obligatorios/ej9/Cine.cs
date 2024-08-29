using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    internal class Cine
    {
        string peli;


        public string Peli { get { return peli; } set { peli = value; } }
        

        public Cine(string peli)
        {
            Peli = peli;

        }
    }
}
