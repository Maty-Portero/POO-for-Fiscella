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

            for (int i = 0; i < 4; i++)
            {
                listilla.Add(new Lavadora());
                listilla.Add(new Television());
            }

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
