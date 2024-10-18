using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();

            for (int i = 0; i < 6; i++)
            {
                jugadores.Add(new Jugador(i));
            }

            Random rnd = new Random();
            Random rdm= new Random();
            Revolver revolver = new Revolver(rnd.Next(1,6), rdm.Next(1,6));

            Juego juego = new Juego(jugadores, revolver);

            juego.ronda();
            Console.ReadKey();
        }
    }
}
