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
        Revolver r = new Revolver();

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

        }
    }
}
