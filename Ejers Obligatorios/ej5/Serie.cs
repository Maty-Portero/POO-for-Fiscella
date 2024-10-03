using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5
{
    internal class Serie : IEntregable
    {
        string titulo = "";
        int numeroTemporadas = 3;
        bool entregado = false;
        string genero = "";
        string creador = "";

        public string Titulo {  get { return titulo; } set { titulo = value; } }
        public int NumeroTemporadas { get { return numeroTemporadas; } set { numeroTemporadas = value; } }
        public bool Entregado { get { return entregado; } set { entregado = value; } }
        public string Genero {  get { return genero; } set { genero = value; } }
        public string Creador {  get { return creador; } set { creador = value; } }

        public Serie() { }

        public Serie(string titulo, string creador)
        {
            this.Titulo = creador;
            this.Creador = creador;
        }

        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
        {
            this.Titulo = titulo;
            this.NumeroTemporadas = numeroTemporadas;
            this.Genero = genero;
            this.Creador = creador;
        }

        public string GetTitulo() { return titulo; }
        public int GetNumeroTemporadas() { return numeroTemporadas; }
        public string GetGenero() { return genero; }
        public string GetCreador() { return creador; }

        public void SetTitulo(string titulo) { this.Titulo = titulo; }
        public void SetNumeroTemporadas() { this.NumeroTemporadas = numeroTemporadas; }
        public void SetGenero(string genero) { this.Genero = genero; }
        public void SetCreador(string creador) { this.Creador = creador; }

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

        public IEntregable compareTo(IEntregable a)
        {
            if (a is Videojuego)
            {
                Videojuego z = (Videojuego)a;
                if (z.GetHorasEstimadas() > this.numeroTemporadas)
                {
                    return z;
                }
                else
                {
                    return this;
                }
            }
            else if (a is Serie)
            {
                Serie z = (Serie)a;
                if (z.GetNumeroTemporadas() > this.numeroTemporadas)
                {
                    return z;
                }
                else
                {
                    return this;
                }
            }
            return null;
        }

    }
}
