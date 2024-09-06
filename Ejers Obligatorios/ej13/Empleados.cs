using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej13
{
    internal class Empleados
    {
        string nombre;
        int edad;
        double salario;

        int plus = 300;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public double Salario { get { return salario; } set { salario = value; } }
        public int Plus { get { return plus; } }

        public Empleados(string nombre, int edad, double salario, int plus) 
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
            this.plus = plus;
        }
    }
}
