using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Baraja
    {
        List<Carta> mazo;
        public List<Carta> Mazo { get { return mazo; } set { mazo = value; } }

        public Baraja(List<Carta> C) 
        { 
            mazo = C;
        }

        public void Barajar()
        {
            Random r = new Random();
            for (int i = 0; i < mazo.Count(); i++)
            {
                int aux = r.Next(0, mazo.Count());
                Carta aux2;
                aux2 = mazo[i];
                mazo[i] = mazo[aux];
                mazo[aux] = aux2;
            }
        }

        public void SiguienteCarta(List<Carta> monton)
        {
            if (mazo[0] != null)
            {
                monton.Add(mazo[0]);
                mazo.RemoveAt(0);
            }
        }
        public void CartasDisponibles()
        {
            Console.WriteLine("Cartas disponibles: " +  mazo.Count);
        }
        public void DarCartas(List<Carta> monton, int numCartas)
        {
            if (numCartas <= mazo.Count())
            {
                for (int i = 0; i < numCartas; i++)
                {
                    SiguienteCarta(monton);
                }
            }
        }
        public void CartasMonton(List<Carta> monton)
        {
            Console.WriteLine("Cartas descartadas: " + monton.Count);
        }
        public void MostrarBaraja()
        {
            for (int i = 0; i < mazo.Count(); i++)
            {
                Console.WriteLine($"{mazo[i].Num} {mazo[i].Palo}");
            }
        }
    }
}
