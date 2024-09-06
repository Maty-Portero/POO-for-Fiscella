using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cartas> cartas = new List<Cartas>();
            List<int> numsExcluidos = new List<int> { 8, 9};
            List<string> palabras = new List<string> { "espadas", "bastos", "oros", "copas" };

            for (int i = 0; i < 41; i++)
            {
                Random r = new Random();
                int n;

                do
                {
                    n = r.Next(1, 13);
                } while (numsExcluidos.Contains(n));

                Random r2 = new Random();
                int index = r2.Next(palabras.Count);

                string palabraAleatoria = palabras[index];


                cartas.Add(new Cartas(n, palabraAleatoria));
            }
            Console.ReadKey();
        }
    }
}
