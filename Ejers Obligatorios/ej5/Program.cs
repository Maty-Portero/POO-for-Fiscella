﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Serie> listillaSeries = new List<Serie>();
            List<Videojuego> listillaVideojuego = new List<Videojuego>();

            //for (int i = 0; i < 5; i++)
            //{
            listillaSeries.Add(new Serie("a", 5, "b", "c"));
            listillaSeries.Add(new Serie("d", 6, "e", "f"));
            listillaVideojuego.Add(new Videojuego("m", 20, "n", "ñ"));
            listillaVideojuego.Add(new Videojuego("o", 5, "p", "q"));
            listillaVideojuego.Add(new Videojuego("o", 80, "p", "q"));
            listillaVideojuego.Add(new Videojuego("o", 5, "p", "q"));
            //}        


            foreach (Serie serie in listillaSeries)
            {
                serie.entregar();
            }

            foreach (Videojuego juego in listillaVideojuego)
            {
                juego.entregar();
            }
            
            int contJuego = 0;
            foreach (Videojuego a in listillaVideojuego)
            {
                contJuego++;
                if (a.isEntregado() == true)
                {
                    a.devolver();
                }
            }

            int contSerie = 0;
            foreach (Serie b in listillaSeries)
            {
                contSerie++;
                if (b.isEntregado() == true)
                {
                    b.devolver();
                }
            }

            int num = listillaVideojuego[0].GetHorasEstimadas();

            foreach (Videojuego juego in listillaVideojuego)
            {
                if(num >= juego.GetHorasEstimadas())
                {
                    Console.WriteLine($"{num}");
                }
                else
                {
                    Console.WriteLine("nt");
                }
            }
            
            Console.ReadKey();
        }
    }
}
