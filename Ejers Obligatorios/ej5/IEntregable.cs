using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5
{
    internal interface IEntregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
        void compareTo(Object a);
    }
}
