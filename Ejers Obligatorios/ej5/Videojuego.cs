using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ej5
{
    internal class Videojuego : IEntregable
    {
        string titulo = "";
        int horasEstimadas = 10;
        bool entregado = false;
        string genero = "";
        string compañia = "";

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int HorasEstimadas { get { return horasEstimadas; } set { horasEstimadas = value; } }
        public bool Entregado { get { return entregado; } set { entregado = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public string Compañia { get { return compañia; } set { compañia = value; } }

        public Videojuego() { }

        public Videojuego(string titulo, string creador)
        {
            this.Titulo = creador;
            this.Compañia = creador;
        }

        public Videojuego(string titulo, int horasEstimadas, string genero, string compañia)
        {
            this.Titulo = titulo;
            this.HorasEstimadas = horasEstimadas;
            this.Genero = genero;
            this.Compañia = compañia;
        }

        public string GetTitulo() { return Titulo; }
        public int GetHorasEstimadas() { return HorasEstimadas; }
        public string GetGenero() { return Genero; }
        public string GetCompañia() { return Compañia; }

        public void SetTitulo(string titulo) { this.Titulo = titulo; }
        public void SetHorasEstimadas(int horasEstimadas) { this.HorasEstimadas = horasEstimadas; }
        public void SetGenero(string genero) { this.Genero = genero; }
        public void SetCompañia(string compañia) { this.Compañia = compañia; }

        public void entregar()
        {
            Entregado = true;
        }
        
        public void devolver()
        {
            Entregado = false;
        }

        public bool isEntregado()
        {
            return Entregado;
        }

        public void compareTo(Object a)
        {
            HorasEstimadas = int.Parse(string.Format("{0}", a));
        }
    }
}
