using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej13
{
    internal class Repartidor : Empleados
    {
        string zona;

        public string Zona { get { return zona; } set { zona = value; } }

        public Repartidor(string nombre, int edad, double salario, int PLUS, string zona) : base(nombre, edad, salario, PLUS) 
        {
            this.zona = zona;
        }

        public double PLUS()
        {
            if (Edad < 25 && zona == "zona 3")
            {
                Salario = Salario + Plus;
            }

            return Salario;
        }
    }
}
