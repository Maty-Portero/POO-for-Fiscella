using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    internal class Program
    {
        static Cuenta cuk = new Cuenta("cuk", 1000);

        static void Main(string[] args)
        {
            int IoR;
            Console.WriteLine("Ingresar: 1     |Retirar : 2     ");
            IoR = int.Parse(Console.ReadLine());

            switch (IoR)
            {
                case 0:
                    Console.WriteLine("Ingreso: ");
                    cuk.Ingresar(double.Parse(Console.ReadLine()));
                    Console.WriteLine("                             ");
                    Console.WriteLine(cuk.Titular + " tiene " + cuk.Saldo + ".");
                    break;

                case 1:
                    Console.WriteLine("Retiro: ");
                    cuk.Retirar(double.Parse(Console.ReadLine()));
                    Console.WriteLine("                             ");
                    Console.WriteLine(cuk.Titular + " tiene " + cuk.Saldo + ".");
                    break;
            }
            

            Console.ReadKey();
        }
    }
}
