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
            List<Persona> list = new List<Persona>();

            for (int i = 0; i < 3; i++) {
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

                list.Add(new Persona(name, age, sex, weight, height));
            }

            foreach (Persona persona in list)
            {
                Console.WriteLine("Calculo del IMC:  -1 = peso ideal    |    0 = debajo de su peso ideal   |    1 = sobre peso");
                Console.WriteLine("La persona esta en " + persona.calcularIMC());
            }

            foreach (Persona persona in list)
            {
                Console.WriteLine("¿Es mayor de edad?:    true = si   |   false = no");
                Console.WriteLine("La persona esta en " + persona.esMayorDeEdad());
            }

            foreach(Persona persona in list)
            {
                Console.WriteLine(persona.Nombre + " tiene " + persona.Edad + " años, su DNI es " + persona.Dni + " de sexo " + persona.Sexo + ", pesa " + persona.Peso + " kg, " + " y mide " + persona.Altura + " metros.");
            }
            Console.ReadKey();
        }
    }
}
