using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    internal class Jugador : IResultado
    {
        string nombre = "Jugador";
        int id;
        float dinero;
        int rondasGanadas = 0;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int ID { get { return id; } set { id = value; } }
        public float Dinero { get { return dinero; } set { dinero = value; } }
        public int RondasGanadas { get { return rondasGanadas; } set { rondasGanadas = value; } }

        public Jugador(int id, float dinero)
        {
            this.id = id;
            this.dinero = dinero;

        }

        public bool PuedeApostar()
        {
            if (dinero > 100)
                return true;
            else
                return false;
        }
        public string Resultado(Random r)
        {
            return $"{r.Next(0, 6)}-{r.Next(0, 6)}";
        } 
    }
}
