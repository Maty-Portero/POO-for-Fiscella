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
        public Raices(double Aa, double Bb, double Cc)
        {
            a = Aa;
            b = Bb;
            c = Cc;
        }

        public void ObtenerRaices()
        {
            double x1 = (-b + Math.Sqrt(GetDiscriminante())) / (2 * a);
            double x2 = (-b - Math.Sqrt(GetDiscriminante())) / (2 * a);
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        public void ObtenerRaiz()
        {
            double x = (-b) / (2 * a);

            Console.WriteLine($"x = {x}");
        }
        public double GetDiscriminante()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
        public bool TieneRaices()
        {
            return GetDiscriminante() > 0;
        }
        private bool TieneRaiz()
        {
            return GetDiscriminante() == 0;
        }
        public void Calcular()
        {
            if (TieneRaices())
                ObtenerRaices();
            else if (TieneRaiz())
                ObtenerRaiz();
            else
                Console.WriteLine("No tiene soluciones");
        }
    }
}
