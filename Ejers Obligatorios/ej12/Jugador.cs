using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Jugador
    {
        int id;
        string nombre = "Jugador";
        bool vivo = true;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public bool Vivo { get { return vivo; } set { vivo = value; } }

        public Jugador(int id)
        {
            this.id = id;
        }

        public bool disparar(Revolver r)
        {
            if (r.PosBala == r.PosActual)
            {
                vivo = false;
                r.siguienteBala();
                return true;
            }
            return false;
        }
    }
}
