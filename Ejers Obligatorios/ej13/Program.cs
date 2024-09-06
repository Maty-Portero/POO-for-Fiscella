using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Repartidor> repartidores = new List<Repartidor>();
            List<Comercial> comerciales = new List<Comercial>();

            repartidores.Add(new Repartidor("Pepe", 35, 1000, 300, "zona 3"));
            repartidores.Add(new Repartidor("Bau", 20, 1000, 300, "zona 3"));
            comerciales.Add(new Comercial("Choko", 25, 500, 300, 250));            
            comerciales.Add(new Comercial("Fabri", 40, 700, 300, 350));

            foreach (Repartidor r in repartidores)
            {
                r.PLUS();

                Console.WriteLine(r.Nombre + " tiene " + r.Edad + " cobra " + r.Salario + " euros");
            }

            foreach (Comercial c in comerciales)
            {
                c.PLUS();

                Console.WriteLine(c.Nombre + " tiene " + c.Edad + " cobra " + c.Salario + " euros");
            }

            Console.ReadKey();
            
        }
    }
}
