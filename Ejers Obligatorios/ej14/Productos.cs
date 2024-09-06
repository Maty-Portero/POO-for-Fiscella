using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej14
{
    internal class Productos
    {
        string nombre;
        double precio;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double Precio { get { return precio; } set { precio = value; } }

        public Productos(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public double CalcularPr(int cantP)
        {
            Precio = cantP * Precio;

            return Precio;
        }
    }
}
