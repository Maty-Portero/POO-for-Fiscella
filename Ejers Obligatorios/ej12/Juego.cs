using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Juego
    {
        List<Jugador> jugadorList = new List<Jugador>();
        Revolver r;

        public Juego(List<Jugador> jugadorList, Revolver r)
        {
            this.jugadorList = jugadorList;
            this.r = r;
        }

        public bool finJuego()
        {
            foreach (var j in jugadorList) 
            {
                if (j.disparar(r) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public void ronda()
        {
            foreach (var j in jugadorList)
            {
                if (j.disparar(r) != true)
                {
                    r.siguienteBala();
                    Console.WriteLine("El " + j.Nombre + j.Id + " esta más vivazo que Mirtha Legrand.");
                }
                else
                {
                    r.siguienteBala();
                    Console.WriteLine("El " + j.Nombre + j.Id + " esta más muerto que Perón.");
                }
            }
        }
    }
}
