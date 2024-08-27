using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = new List<Libro>();

            for (int i = 0; i < 1; i++)
            {
                libros.Add(new Libro(9876543210, "La historia Malagense", "Edgar Alan Poe", 50));
                libros.Add(new Libro(0123456789, "La mitología Griega", "Bautista Lobo", 100));
            }

            foreach (Libro l in libros)
            {
                l.mostrarInfo();
                //l.NumPaginas
            }

            Console.ReadKey();
        }
    }
}
