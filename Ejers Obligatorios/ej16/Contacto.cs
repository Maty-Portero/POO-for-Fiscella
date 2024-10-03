using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej16
{
    internal class Contacto
    {
        string nombre;
        string telefono;

        public string Nombre {  get { return nombre; } set { nombre = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }


        public Contacto(string nombre, string telefono) 
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }
    }
}
