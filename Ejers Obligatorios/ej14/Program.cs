using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Perecedero> productsP = new List<Perecedero>();
            List<NoPerecedero> productsNoP = new List<NoPerecedero>();

            int cant = 5;

            for (int i = 0; i <= cant; i++)
            {
                productsP.Add(new Perecedero("Tomate", 1000, 3));
                productsNoP.Add(new NoPerecedero("dinosaurio", 5000, "Juguetes"));
            }

            foreach (Perecedero p in productsP)
            {
                p.CalcularP(cant);

                Console.WriteLine(p.Precio);
            }

            foreach (NoPerecedero noP in productsNoP)
            {
                noP.CalcularNoP(cant);

                Console.WriteLine(noP.Precio);
            }

            Console.ReadKey();
        }
    }
}
