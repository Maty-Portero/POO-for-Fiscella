using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Password> list = new List<Password>();
            List<Password> lista = new List<Password>();

            int cuantas;
            Console.WriteLine("Ingrese cuantas contraseñas quiere guardar: ");
            cuantas = int.Parse(Console.ReadLine());

            int largo;
            Console.WriteLine("Ingrese el largo de las contraseñas: 1-8");
            largo = int.Parse(Console.ReadLine());

            for (int i = 0; i < cuantas; i++)
            {
                list.Add(new Password());
                lista.Add(new Password());
            }

            foreach (Password lista1 in list)
            {
                Console.WriteLine("la contraseña es " + lista1.generarPassword());
            }

            foreach (Password lista2 in lista)
            {
                Console.WriteLine("su contraseña es fuerte? " + lista2.esFuerte());
            }

            Console.ReadKey();
        }
    }
}
