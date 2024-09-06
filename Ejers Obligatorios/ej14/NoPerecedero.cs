using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej14
{
    internal class NoPerecedero : Productos
    {
        string tipos;

        public string Tipos { get { return tipos; } set { tipos = value; } }

        public NoPerecedero(string nombre, double precio, string tipos) : base (nombre, precio) 
        {
            this.tipos = tipos;
        }

        public double CalcularNoP(int cantP)
        {
            Precio = cantP * Precio;

            return Precio;
        }
    }
}
