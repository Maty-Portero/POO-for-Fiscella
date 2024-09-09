using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej15
{
    internal class Productos
    {
        int id;
        double litros;
        double precio;
        string marca;

        public int ID { get { return id; } set { id = value; } }
        public double Litros { get { return litros; } set { litros = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public string Marca { get { return marca; } set { marca = value; } }


        public Productos(int id, double litros, double precio, string marca)
        {
            this.id = id;
            this.litros = litros;
            this.precio = precio;
            this.marca = marca;
        }

    }
}
