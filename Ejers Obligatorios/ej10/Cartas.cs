using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Carta
    {
        int num;
        string palo;

        public int Num { get { return num; } set { num = value; } }
        public string Palo { get { return palo; } set { palo = value; } }

        public Carta(int N, string P)
        {
            num = N;
            palo = P;
        }
    }
}