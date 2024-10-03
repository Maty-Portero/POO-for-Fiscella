using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.IO;
=======
>>>>>>> 430fe4902fd1d86a674188b0e1b9f34ed2ab69d6
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej15
{
    internal class Almacen
    {
<<<<<<< HEAD
        List<List<Productos>> estanterias = new List<List<Productos>>();
        List<BebidaAzucarada> bebAzucar = new List<BebidaAzucarada>();
        List<AguaMineral> aguitaMine = new List<AguaMineral>();

        public Almacen() 
        {

        }

        public double calculoDeBebidas()
        {
            double total = 0.0;
            foreach (List<Productos> listaProductos in estanterias)
            {
                foreach (Productos bebida in listaProductos) 
                { 
                    total += bebida.Precio;
                }
            }
            return total;
        }

        public double calculoDeMarca()
        {
            double totalMarca = 0.0;
            string linea;

            Console.WriteLine("ingrese una marca:");
            linea = Console.ReadLine();


            bool existe = false;

            foreach (List<Productos> listaProductos in estanterias)
            {
                foreach (Productos bebida in listaProductos)
                {
                    if (linea == bebida.Marca)
                    {
                        totalMarca += bebida.Precio;
                        existe = true;
                    }
                }
            }


            if(!existe)
            {
                Console.WriteLine("no existe esa marca");
            }


            return totalMarca;
        }

        public void calculoTotalEstanteria()
        {
            double totalEstanteria = 0.0;

            foreach(List<Productos> listaProductos in estanterias)
            {
                foreach (Productos prodXEstantes in listaProductos)
                {
                    totalEstanteria += prodXEstantes.Precio;
                }
            }
        }

        public void agregarProducto()
        {            
            Random rand = new Random();
            int id = rand.Next(000, 999);
            AguaMineral agua1 = new AguaMineral("Argentina", id, 2.25, 2000, "Del valle");

            foreach (AguaMineral aguaMine in aguitaMine)
                if (aguaMine.ID != agua1.ID)
                    aguitaMine.Add(agua1);
        }

        public void eliminarProducto(int id)
        {
            foreach(List<Productos> productos in estanterias)
            {
                foreach (Productos prodXEstantes in productos)
                {
                    if(prodXEstantes.ID == id)
                    {
                        productos.Remove(prodXEstantes);
                        break;
                    }
                }
            }                   
        }

        public void mostrarInfo()
        {

        }
=======

>>>>>>> 430fe4902fd1d86a674188b0e1b9f34ed2ab69d6
    }
}
