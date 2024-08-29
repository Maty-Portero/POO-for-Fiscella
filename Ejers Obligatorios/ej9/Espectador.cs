using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    internal class Espectador
    {
        string nombre;
        int edad;
        double dinero;
        bool sentado = false;
        Asiento asiento;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public double Dinero { get { return dinero; } set { dinero = value; } }
        public bool Sentado { get { return sentado; } set { sentado = value; } }
        public Asiento Asiento { get { return asiento; } set { asiento = value; } }

        public Espectador(string nombre, int edad, double dinero, bool sentado, Asiento asiento)
        {
            Nombre = nombre;
            Edad = edad;
            Dinero = dinero;
            Sentado = sentado;
            Asiento = asiento;
        }
    }
}
