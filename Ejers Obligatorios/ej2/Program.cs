using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i > 3; i++) {
                string name;
                Console.WriteLine("Ingrese su nombre: ");
                name = Console.ReadLine();

                int age;
                Console.WriteLine("Ingrese su edad: ");
                age = int.Parse(Console.ReadLine());

                char sex;
                Console.WriteLine("Ingrese su sexo: ");
                sex = char.Parse(Console.ReadLine());

                double weight;
                Console.WriteLine("Ingrese su peso: ");
                weight = double.Parse(Console.ReadLine());

                double height;
                Console.WriteLine("Ingrese su altura: ");
                height = double.Parse(Console.ReadLine());

            //}
            Persona persona1 = new Persona(name, age, sex, weight, height);
            Persona persona2 = new Persona(name, age, sex, 59.6, 1.79);
            //Persona persona3 = new Persona(name, age, sex, weight, height);

            Console.WriteLine("Calculo del IMC:  -1 = peso ideal    |    0 = debajo de su peso ideal   |    1 = sobre peso");
            Console.WriteLine("La persona 1 esta en " + persona1.calcularIMC());
            Console.WriteLine("La persona 2 esta en " + persona2.calcularIMC());
            //Console.WriteLine("La persona 3 esta en " + persona3.calcularIMC());

            Console.WriteLine("¿Es mayor de edad?:    true = si   |   false = no");
            Console.WriteLine("La persona 1 esta en " + persona1.esMayorDeEdad());
            Console.WriteLine("La persona 2 esta en " + persona2.esMayorDeEdad());
            //Console.WriteLine("La persona 3 esta en " + persona3.esMayorDeEdad());

            Console.WriteLine(persona1.Nombre + " tiene " + persona1.Edad + " años, su DNI es " + persona1.generaDNI() + " de sexo " + persona1.Sexo + ", pesa " + persona1.Peso + " kg, " + " y mide " + persona1.Altura + " metros.");
            Console.WriteLine(persona2.Nombre + " tiene " + persona2.Edad + " años, su DNI es " + persona2.generaDNI() + " de sexo " + persona2.Sexo + ", pesa " + persona2.Peso + " kg, " + " y mide " + persona2.Altura + " metros.");
        }
    }
}
