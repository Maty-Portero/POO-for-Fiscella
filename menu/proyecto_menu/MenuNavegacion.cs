using menu;
using System;

public class MenuNavegacion
{
    private readonly MenuPrincipal menu;
    private int seleccionarItem = 0;
    private int seleccionarMenu = 1;

    public MenuNavegacion(MenuPrincipal menu)
    {
        this.menu = menu;
    }

    public int posMenu(int posMenu)
    {
        int posUbicacion;

        int x = 1;
        int tamanio = 0;
        
        foreach (var m in menu.menu)
        {
            if(x == posMenu)
            {
                return tamanio;
            }
            tamanio += m.NombreMenu.Length;
            x++;
        }


        return tamanio;
    }

    public void Iniciar()
    {        
        menu.Dibujar(1, 1, seleccionarMenu, seleccionarItem);

        bool arrancar = true;

        while (arrancar)
        {
            var tecla = Console.ReadKey(true).Key;
            switch (tecla)
            {
                case ConsoleKey.UpArrow:
                    if (seleccionarItem > 0)
                    {
                        seleccionarItem--;
                    }
                    else
                    {
                        seleccionarItem = menu.ContadorItemMenu(seleccionarMenu) - 1;
                    }
                    menu.Dibujar(1, 1, seleccionarMenu, seleccionarItem);
                    break;
                case ConsoleKey.DownArrow:
                    if (seleccionarItem < menu.ContadorItemMenu(seleccionarMenu) - 1)
                    {
                        seleccionarItem++;
                    }
                    else
                    {
                        seleccionarItem = 0;
                    }
                    menu.Dibujar(1, 1, seleccionarMenu, seleccionarItem);
                    break;
                case ConsoleKey.Enter:
                    string opcion = menu.ObtenerOpcion(seleccionarMenu, seleccionarItem);
                    menu.EjecutarAccion(opcion);
                    menu.Dibujar(1, 1, seleccionarMenu, seleccionarItem);
                    break;
                case ConsoleKey.LeftArrow:
                    if (seleccionarMenu > 1)
                    {
                        seleccionarMenu--;
                        seleccionarItem = 0;
                    }
                    else
                    {
                        seleccionarMenu = menu.ContadorMenu();
                    }
                    menu.Dibujar(1, 1, seleccionarMenu, seleccionarItem);
                    break;
                case ConsoleKey.RightArrow:
                    if (seleccionarMenu < menu.ContadorMenu())
                    {
                        seleccionarMenu++;
                        seleccionarItem = 0;
                    }
                    else
                    {
                        seleccionarMenu = 1;
                    }
                    
                    menu.Dibujar(posMenu(seleccionarMenu), 1, seleccionarMenu, seleccionarItem);
                    break;
            }
        }
    }
}