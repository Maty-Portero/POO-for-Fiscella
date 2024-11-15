using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ej11
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();
            for (int i = 1; i <= 5; i++)
            {
                jugadores.Add(new Jugador(i, rnd.Next(500, 10001)));
            }

            string[] equipos = { "San Lorenzo", "Huracan", "Boca", "River", "Independiente", "Racing", "Velez", "SacaChispas", "Los Andes" }; 
            Partido partido = new Partido(equipos);

            Juego juego = new Juego(jugadores, partido);

            Task t = Task.Run(async delegate
            {
                while (juego.Terminado == false)
                {
                    juego.Ronda(rnd);
                    await Task.Delay(1000);
                }
            });
            t.Wait();



            Console.ReadKey();
        }
    }
}
