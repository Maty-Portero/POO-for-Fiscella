using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            bool infinidad = true;
            List<Raices> raices = new List<Raices>();
            while (infinidad)
            {
                i++;
                Console.WriteLine("Ingrese los valores de la ecuacion (a, b, c)");
                raices.Add(new Raices(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                raices[i].Calcular();
                Console.WriteLine("Desea seguir calculando raices? Si: 1 | No: 2");
                int respuesta = int.Parse(Console.ReadLine());
                switch (respuesta)
                {
                    case 1:
                        break;
                    case 2:
                        infinidad = false;
                        break;
                }
            }
        }
    }
}
}
