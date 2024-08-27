using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej7
{
    internal class Raices
    {
        double a;
        double b;
        double c;

        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }

        public Raices(double a, double b, double c) 
        {
            A = a; 
            B = b; 
            C = c;
        }

        public void obtenerRaices()
        {

        }
        public void obtenerRaiz()
        {

        }

        public double getDiscriminate(double a , double b, double c)
        {
            double discriminante = (b * b) - 4 * a * c;

            return discriminante;
        }

        /*public bool tieneRaices()
        {
            bool tieneraices;

            if () { }
            return tieneraices;
        }*/

        public void tieneRaiz()
        {

        }

        public void calcular(double a, double b, double c)
        {

        }
    }
}
