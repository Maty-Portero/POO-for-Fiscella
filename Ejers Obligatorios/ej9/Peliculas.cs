using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ej9
{
    internal class Peliculas
    {
        string titulo;
        string duracion;
        int edadMin;
        string director;
        double precio;

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Duracion { get { return duracion; } set { duracion = value; } }
        public int EdadMin { get { return edadMin; } set { edadMin = value; } }
        public string Director { get { return director; } set { director = value; } }
        public double Precio { get { return precio; } set { precio = value; } }

        public Peliculas(string titulo, string duracion, int edadMin, string director, double precio)
        {
            Titulo = titulo;
            Duracion = duracion;
            EdadMin = edadMin;
            Director = director;
            Precio = precio;
        }
    }
}
