using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Electrodomestico> listilla = new List<Electrodomestico>();

            Lavadora lav1 = new Lavadora();
            Lavadora lav2 = new Lavadora();
            Lavadora lav3 = new Lavadora();
            Lavadora lav4 = new Lavadora();
            Lavadora lav5 = new Lavadora();

            Television tel1 = new Television();
            Television tel2 = new Television();
            Television tel3 = new Television();
            Television tel4 = new Television();
            Television tel5 = new Television();

            listilla.Add(lav1);
            listilla.Add(lav2);
            listilla.Add(lav3);
            listilla.Add(lav4);
            listilla.Add(lav5);

            listilla.Add(tel1);
            listilla.Add(tel2);
            listilla.Add(tel3);
            listilla.Add(tel4);
            listilla.Add(tel5);

            double precioElects = 0;
            foreach (Electrodomestico ele in listilla)
            {
                ele.PrecioFinal();

                precioElects += ele.PrecioBase;
            }
            Console.WriteLine(precioElects);
            Console.ReadKey();
        }
    }
}
