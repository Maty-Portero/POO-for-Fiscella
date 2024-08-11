using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2
{
    internal class Persona
    {
        string nombre = "";
        int edad = 0;
        int DNI = 00000001;
        char sexo = 'H';
        double peso = 0;
        double altura = 0;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public int Dni { get { return DNI; } }
        public char Sexo { get { return sexo; } set { sexo = value; } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }
        
        public Persona()
        {
            nombre = "roberto";
            edad = 40;
            DNI = 28945614;
            sexo = 'H';
            peso = 80.5;
            altura = 1.88;
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            DNI = 28945614;
            this.sexo = sexo;
            peso = 80.5;
            altura = 1.88;
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            generaDNI();
            this.sexo = sexo;
            comprobarSexo(sexo);
            this.peso = peso;
            this.altura = altura;
        }

        public int calcularIMC()
        {
            double imc = peso / (altura * 2);
            if (imc > 20)
            {
                return -1;
            }
            else if (imc > 25 && imc < 20)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public bool esMayorDeEdad()
        {
            if (this.edad > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool comprobarSexo(char sexo)
        {
            if (sexo == 'H')
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int generaDNI()
        {
            Random aleatorio = new Random();
            int dni;
            dni = aleatorio.Next(00000001, 99999999);

            if (dni % 2 == 0)
            {
                sexo = 'H';
            }
            else
            {
                sexo = 'M';
            }

            return dni;
        }
    }
}
