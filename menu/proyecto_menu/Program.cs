/* 
Partiendo de este codigo, terminar el programa en el que se pueda ver el menu y con las teclas recorrerlo y poder elegir una opcion para hacer algo diferente en cada caso
*/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menus = new Dictionary<string, string[]>
            {
                { " Archivo ", new[] { "Nuevo Cliente", "Modificar Cliente", "Listar Clientes", "Salir" } },
                { " Editar " , new[] { "Nuevo Producto", "Modificar Producto", "Eliminar Producto", "Listar Producto", "Salir" } },
                { " Empresa ", new[] { "Nueva Empresa", "Modificar Empresa", "Eliminar Empresa", "Listar Empresa", "Salir" } }
            };

            var menuPrincipal = new MenuPrincipal(menus);

            foreach (var subMenu in menus)
            {
                foreach (var opcion in subMenu.Value)
                {
                    if (opcion == "Salir")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine("Saliendo del programa...");
                            Environment.Exit(0);
                        });
                    }
                    else
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                }
            }

            var menuNavigator = new MenuNavegacion(menuPrincipal);
            menuNavigator.Iniciar();
        }
    }
}