using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    internal class Juego
    {
        List<Jugador> jugadores;
        Partido partido;
        float pozo;
        bool terminado = false;

        public List<Jugador> Jugadores { get { return jugadores; } set { jugadores = value; } }
        public Partido Partido { get { return partido; } set { partido = value; } }
        public float Pozo { get { return pozo; } set { pozo = value; } }
        public bool Terminado { get { return terminado; } set { terminado = value; } }

        public Juego(List<Jugador> jugadores, Partido partido)
        {
            this.jugadores = jugadores;
            this.partido = partido;
        }

        public void Ronda(Random r)
        {
            string result = partido.Resultado(r);
            Console.WriteLine($"El juego será entre: {partido.Enfrentamiento(r)}. Inicien sus apuestas");
            for (int i = jugadores.Count() - 1; i >= 0; i--)
            {
                if (jugadores[i].PuedeApostar() == true)
                    {
                        jugadores[i].Dinero -= 100;
                        pozo += 100;
                }
                else
                {
                    jugadores.RemoveAt(i);
                }
            }
            Console.WriteLine($"RESULTADO: {result}");
            if (jugadores.Count > 0)
            {
                foreach (Jugador j in jugadores)
                {
                    string apuesta = j.Resultado(r);
                    if (result == apuesta)
                    {
                        j.RondasGanadas++;
                        Console.WriteLine($"El ganador fue: {j.Nombre} {j.ID}");
                        if (j.RondasGanadas == 2)
                        {

                            j.Dinero += pozo;
                            pozo = 0;
                            Console.WriteLine($"GG {j.Nombre} {j.ID} te llevas el pozo!!... {j.Nombre} {j.ID} cuenta ahora con ${j.Dinero}");
                            terminado = true;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{j.Nombre} {j.ID} no ganó la apuesta (su apuesta: {apuesta})");
                    }
                }
            }
            else
            {
                Console.WriteLine("La casa se lleva el pozo");
                terminado = true;
            }
        }
    }
}
