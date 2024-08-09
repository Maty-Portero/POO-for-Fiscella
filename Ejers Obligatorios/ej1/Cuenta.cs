using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    internal class Cuenta
    {
        string titular;
        double saldo;

        public double Saldo 
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public Cuenta(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
        public Cuenta(string titular)
        {
            this.Titular = titular;
        }

        public double Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
            }
            return Saldo;
        }

        public double Retirar(double cantidad)
        {            
            if (Saldo - cantidad  < 0)
            {
                Saldo = 0;
            }
            else
            {
                Saldo -= cantidad;
            }

            return Saldo;
        }
    }
}
