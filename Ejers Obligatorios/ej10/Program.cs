using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Carta> cartasMazo = new List<Carta>();
            List<Carta> monton = new List<Carta>();
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 12; k++)
                {
                    if (k != 8 && k != 9)
                    {
                        if (i == 0)
                            cartasMazo.Add(new Carta(k, "oro"));
                        else if (i == 1)
                            cartasMazo.Add(new Carta(k, "copa"));
                        else if (i == 2)
                            cartasMazo.Add(new Carta(k, "espada"));
                        else
                            cartasMazo.Add(new Carta(k, "basto"));
                    }
                }
            }

            Baraja mazo = new Baraja(new List<Carta>(cartasMazo));
            mazo.Barajar();
            Console.WriteLine("Baraja mezclada: ");
            Console.WriteLine("========================");
            mazo.MostrarBaraja();
            Console.WriteLine("========================");

            bool infinidad = true;
            while (infinidad)
            {
                Console.WriteLine("========================");
                Console.WriteLine("1: Siguiente Carta");
                Console.WriteLine("2: Pedir cartas");
                Console.WriteLine("3: Cartas disponibles");
                Console.WriteLine("4: Tus cartas");
                Console.WriteLine("5: Mostrar mazo");
                Console.WriteLine("6: Terminar");
                Console.WriteLine("========================");
                string opcion = Console.ReadLine();
                if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4" || opcion == "5" || opcion == "6") 
                {
                    switch (opcion) 
                    {
                        case "1":
                            if (mazo.Mazo[0] == null)
                            {
                                Console.WriteLine("No quedan cartas del mazo.");
                                break;
                            }
                            mazo.SiguienteCarta(monton);
                            break;
                        case "2":
                            Console.WriteLine("¿Cuantas cartas desea pedir?: ");
                            int cant = Convert.ToInt32(Console.ReadLine());
                            if (cant <= mazo.Mazo.Count)
                            {
                                mazo.DarCartas(monton, cant);
                                break;
                            }
                            else 
                            {
                                Console.WriteLine("Se excede de las cartas disponibles.");
                                break; 
                            }
                        case "3": mazo.CartasDisponibles(); break;
                        case "4": mazo.CartasMonton(monton); break;
                        case "5": mazo.MostrarBaraja(); break;
                        case "6": infinidad = false; break;
                    }
                }
            }
        }
    }
}   
