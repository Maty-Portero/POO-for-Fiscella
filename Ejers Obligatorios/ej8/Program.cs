using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Profesores> profesores = new List<Profesores>();
            List<Estudiantes> estudiantes = new List<Estudiantes>();
            List<Aula> aula = new List<Aula>();

            int contador = 0, contH = 0, contM = 0;
            for (int i = 0; i < 1; i++)
            {
                profesores.Add(new Profesores("Pepe", 30, "Hombre", "Matemáticas", true));
                estudiantes.Add(new Estudiantes("Jose", 17, "Hombre", 5, true, 1));
                aula.Add(new Aula(1, 30, "Matemáticas", "Pepe", false));

                profesores.Add(new Profesores("Juan", 40, "Hombre", "Física", false));
                estudiantes.Add(new Estudiantes("Maria", 16, "Mujer", 7, false, 8));
                aula.Add(new Aula(2, 40, "Filosofia", "", false));

                foreach (Estudiantes e in estudiantes)
                {
                    if (e.Presente)
                    {
                        contador++;
                    }
                }
            }
            foreach(Profesores p in profesores)
            {
                if (contador <= estudiantes.Count / 2 && p.Disponibilidad == true)
                {
                    foreach (Aula a in aula)
                    {
                        a.ClaseE = true;

                        if (a.ClaseE == true)
                        {
                            foreach(Estudiantes e in estudiantes)
                            {
                                if(e.Sexo == "Hombre")
                                {
                                    contH++;
                                }
                                else if(e.Sexo == "Mujer")
                                {
                                    contM++;
                                }
                            }                            
                        }
                    }
                }
            }

            Console.WriteLine("La cantidad de alumnos es " + contH);
            Console.WriteLine("La cantidad de alumnas es " + contM);
            Console.ReadKey();
            




        }
    }
}
