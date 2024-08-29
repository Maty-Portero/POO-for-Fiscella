using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Espectador> espectadores = new List<Espectador>();
            List<Asiento> asientos = new List<Asiento>();
            List<Cine> cines = new List<Cine>();
            List<Peliculas> peliculas = new List<Peliculas>();
                        
            cines.Add(new Cine("DeadPool & Wolverine"));
            cines.Add(new Cine("Romper el circulo"));

            peliculas.Add(new Peliculas("DeadPool & Wolverine", "2:15 hs", 16, "Shawn Levy", 5000));
            peliculas.Add(new Peliculas("Romper el circulo", "1:10 hs", 16, "PEPE", 7000));

            for (int letra = 'A'; letra <= 'I'; letra++)
            {
                for (int numero = 1; numero <= 8; numero++)
                {
                    asientos.Add(new Asiento(false, letra + "" + numero));
                }
            }
             
            Random random = new Random();
            int r1 = random.Next(1, 72);
            asientos[r1].Ocupado = true;

            espectadores.Add(new Espectador("Choko", 17, 5000, false, asientos[r1]));
            espectadores.Add(new Espectador("Fabri", 10, 15000, false, asientos[r1]));
            espectadores.Add(new Espectador("Maxi", 11, 10000, false, asientos[r1]));
            espectadores.Add(new Espectador("Bauti", 25, 7000, false, asientos[r1]));

            
            foreach (Peliculas p in peliculas) 
            {
                if(p.Titulo == "DeadPool & Wolverine")
                {
                    Console.WriteLine("queres ver deadpool y wolverine");
                    foreach (Espectador e in espectadores)
                    {
                        if (e.Dinero >= p.Precio && e.Edad >= p.EdadMin)
                        {
                            e.Sentado = true;
                            Console.WriteLine(e.Nombre + " esta sentado.");
                        }
                    }
                }
                break;
            }          


            Console.ReadKey();

        }
    }
}
