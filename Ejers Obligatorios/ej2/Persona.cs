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
        string DNI = "";
        char sexo = 'H';
        double peso = 0;
        double altura = 0;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public string Dni { get { return DNI;} set { DNI = value; } }
        public char Sexo { get { return sexo; } set { sexo = value; } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }
        
        public Persona() { generaDNI(); }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            generaDNI();
            this.sexo = sexo;
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

        public void generaDNI()
        {
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            Random r = new Random();
            int dienai = r.Next(00000000, 99999999);
            for (int i = 0; i <= 23; i++)
            {
                if (dienai % 23 == i)
                {
                    Dni = dienai.ToString();
                    Dni += letras[i];
                }
            }
        }
    }
}
