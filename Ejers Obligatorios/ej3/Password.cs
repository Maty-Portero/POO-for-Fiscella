using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3
{
    internal class Password
    {
        int longitud = 8;
        string contrasenia;

        public int Longitud { get { return longitud; } set { longitud = value; } }
        public string Contrasenia { get { return contrasenia; } set { contrasenia = value; } }

        public Password()
        {
            Longitud = 8;
            Contrasenia = "";
        }

        public Password(int longitud)
        {
            this.Longitud = longitud;
            generarPassword();
        }

        public string generarPassword()
        {
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder token = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }

            Contrasenia = token.ToString();

            return Contrasenia;
        }

        public bool esFuerte()
        {
            int mayusas = 0;
            int minusas = 0;
            int numsas = 0;

            for (int i = 0; i < Contrasenia.Length; i++)
            {
                if (Contrasenia[i] >= 97 && Contrasenia[i] <= 122)
                {
                    minusas++;
                }
                else if (Contrasenia[i] >= 65 && Contrasenia[i] <= 90)
                {
                    mayusas++;
                }
                else
                {
                    numsas++;
                }
            }

            if (mayusas > 2 && minusas > 1 && numsas > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetContrasenia()
        {
            return Contrasenia;
        }

        public int GetLongitud()
        {
            return Longitud;
        }

        public void SetLongitud(int longitud)
        {
            this.Longitud = longitud;
        }
    }
}
