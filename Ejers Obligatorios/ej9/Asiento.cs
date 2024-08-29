using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    internal class Asiento
    {
        bool ocupado = false;
        string cordasientos;

        public bool Ocupado { get { return ocupado; } set { ocupado = value; } }
        public string cordAsientos { get { return cordasientos; } set { cordasientos = value; } }
        
        public Asiento(bool ocupado, string cordasientos)
        {
            Ocupado = ocupado;
            cordAsientos = cordasientos;

        }
    }
}
