using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej8
{
    internal class Profesores
    {
        string nombre;
        int edad;
        string sexo;
        string materia;
        bool disponibilidad;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public string Sexo { get { return sexo; } set { sexo = value; } }
        public string Materia { get { return materia; } set { materia = value; } }
        public bool Disponibilidad { get { return disponibilidad; } set { disponibilidad = value; } }

        public Profesores(string nombre, int edad, string sexo, string materia, bool disponibilidad )
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.materia = materia;
            this.disponibilidad = disponibilidad;
        }
    }
}
