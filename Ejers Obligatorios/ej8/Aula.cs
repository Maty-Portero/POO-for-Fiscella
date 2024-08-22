using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej8
{
    internal class Aula
    {
        List<int> id = new List<int>();
        int numMaxEstudiantes;
        string materia;
        string nombreProf;
        bool claseE;

        public List<int> ID { get { return id; } set { id = value; } }
        public int NumMaxEstudiantes { get { return numMaxEstudiantes; } set { numMaxEstudiantes = value; } }
        public string Materia { get { return materia; } set { materia = value; } }
        public string NombreProf { get { return nombreProf; } set { nombreProf = value; } }
        public bool ClaseE { get { return claseE; } set { claseE = value; } }

        public Aula(int id, int numMaxEstudiantes, string materia, string nombreProf, bool claseE)
        {
            this.id.Add(id);
            this.numMaxEstudiantes = numMaxEstudiantes;
            this.materia = materia;
            this.nombreProf = nombreProf;
            this.claseE = claseE;
        }
    }
}
