using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej6
{
    internal class Libro
    {
        long isbn;
        string titulo;
        string autor;
        int numPaginas;

        public long ISBN { get { return isbn; } set { isbn = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor{ get { return autor; } set { autor = value; } }
        public int NumPaginas { get { return numPaginas; } set { numPaginas = value; } }

        public Libro(long isbn, string titulo, string autor, int numPag) 
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            NumPaginas = numPag;
        }



        public void mostrarInfo()
        {
            Console.WriteLine("El " + Titulo + " con " + ISBN + " por el autor " + Autor + " tiene " + NumPaginas + " paginas."); 
        }
    }
}
