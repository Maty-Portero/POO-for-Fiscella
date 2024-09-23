using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej16
{
    internal class AgendaContactos
    {
        List<Contacto> agendaContactos = new List<Contacto>();

        int tamaño = 10;

        public int Tamaño { get { return tamaño; } set { value = tamaño; } }

        public AgendaContactos() { }

        int contadorContactos = 0;

        public void existeContacto(string nombre, string telefono)
        {
            for (int i = 0; i < contadorContactos; i++)
                if (nombre.Equals(agendaContactos[i].Nombre))
                    Console.WriteLine("Ya existe un contacto con ese nombre");
        }

        public void aniadirContacto(string nombre, string telefono)
        {
            if (contadorContactos <= 10)
            {
                agendaContactos[contadorContactos] = new Contacto(nombre, telefono);
                contadorContactos++;
            }
            else
                Console.WriteLine("La agenda está llena");
        }

        public void listarContacto()
        {
            if (contadorContactos == 0)
                Console.WriteLine("No hay contactos");
            else
                for (int i = 0; i < contadorContactos; i++)
                    Console.WriteLine(agendaContactos[i].Nombre + "-" + "Tel.:" + agendaContactos[i].Telefono);
        }

        public void buscaContacto(string nombre)
        {
            bool encontrado = false;

            for (int i = 0; i < contadorContactos; i++)
                if (nombre.Equals(agendaContactos[i].Nombre))
                {
                    Console.WriteLine("Tel.:" + agendaContactos[i].Telefono);
                    encontrado = true;
                }

            if (!encontrado)
            {
                Console.WriteLine("Contacto Inexistente");
            }
        }

        public void eliminarContacto(string nombre, string telefono)
        {
            bool encontrado = false;

            if (contadorContactos == 0)
                Console.WriteLine("No hay contactos");
            else
                for (int i = 0; i < contadorContactos; i++)
                    if (nombre.Equals(agendaContactos[i].Nombre))
                    {
                        agendaContactos.Remove(agendaContactos[i]);
                        encontrado = true;
                    }
        }

        public void agendaLlena()
        {
            if (contadorContactos >= 10)
                Console.WriteLine("La agenda esta llena");
        }

        public void huecosLibres()
        {
            int espacioLibre = 10 - contadorContactos;

            Console.WriteLine("Quedan " + espacioLibre + " espacios.");
        }
    }
}
