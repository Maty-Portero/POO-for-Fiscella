using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    internal class Electrodomestico
    {
        double precioBase = 100;
        string color = "blanco";
        char consumoEnergetico = 'F';
        double peso = 5;

        public double PrecioBase { get { return precioBase; } set { precioBase = value; } } 
        public string Color { get { return color; } set { color = value; } }
        public char ConsumoEnergetico { get { return consumoEnergetico; } set { consumoEnergetico= value; } }
        public double Peso { get { return peso; } set { peso = value; } } 


        public Electrodomestico() { }

        public Electrodomestico(double precioBase, double peso)
        {
            precioBase = 100;
            peso = 5;
        }

        public Electrodomestico(double precioBase, string color, char consumoEnergetico, double peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }

        public double GetPrecioBase()
        {
            return precioBase;
        }

        public string GetColor()
        {
            return color;
        }

        public char GetConsumoEnergetico()
        {
            return consumoEnergetico;
        }
    }
}
