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
            profesores.Add(new Profesores("Pepe", 30, "Hombre", "Matemáticas", true));
            profesores.Add(new Profesores("Juan", 40, "Hombre", "Física", false));

            estudiantes.Add(new Estudiantes("Jose", 17, "Hombre", 5, true, 1));
            estudiantes.Add(new Estudiantes("Maria", 16, "Mujer", 7, false, 8));
           
            aula.Add(new Aula(1, 30, "Matemáticas", "Pepe", false));
            aula.Add(new Aula(2, 40, "Filosofia", "", false));




            foreach (Estudiantes e in estudiantes)
            {
                if (e.Presente)
                {
                    contador++;
                }
            }

            foreach (Profesores p in profesores)
            {
                if (p.Nombre == "Pepe")
                {
                    if (p.Disponibilidad)
                    {
                        foreach (Estudiantes e in estudiantes)
                        {
                            if (contador <= estudiantes.Count / 2)
                            {
                                foreach (Aula a in aula)
                                {
                                    if (a.Materia == "Matemáticas")
                                    {
                                        a.ClaseE = true;

                                        if (e.Sexo == "Hombre" && e.Calificacion >= 6)
                                        {
                                            contH++;
                                        }
                                        else if (e.Sexo == "Mujer" && e.Calificacion >= 6)
                                        {
                                            contM++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                break;
            }

            Console.WriteLine("La cantidad de alumnos aprobados es " + contH);
            Console.WriteLine("La cantidad de alumnas aprobados es " + contM);
            Console.ReadKey();
            




        }
    }
}
