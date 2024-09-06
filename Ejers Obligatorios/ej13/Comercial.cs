using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej13
{
    internal class Comercial : Empleados
    {
        double comision;

        public double Comision { get { return comision; } set { comision = value; } }

        public Comercial(string nombre, int edad, double salario, int PLUS, double comision) : base(nombre, edad, salario, PLUS)
        {
            this.comision = comision;
        }

        public double PLUS()
        {
            if (Edad > 30 && comision > 200)
            {
                Salario = Salario + Plus;
            }

            return Salario;
        }
    }
}
