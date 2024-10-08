using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public bool aniadirContacto(string nombre, string telefono)
        {            
            if (contadorContactos <= 10)
            {
                agendaContactos.Add(new Contacto(nombre, telefono));
                contadorContactos++;
                return true;
            }
            return false;
        }

        public void listarContacto()
        {
            if (contadorContactos == 0)
                Console.WriteLine("No hay contactos");
            else
                for (int i = 0; i < contadorContactos; i++)
                    Console.WriteLine(agendaContactos[i].Nombre + " - " + agendaContactos[i].Telefono);
        }

        public Contacto buscaContacto(string telefono)
        {
            for (int i = 0; i < contadorContactos; i++) { 
                if (telefono.Equals(agendaContactos[i].Telefono))
                {
                    return agendaContactos[i];
                }
            }
            return null;
        }

        public void eliminarContacto(Contacto c)
        {
            agendaContactos.Remove(c);
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
