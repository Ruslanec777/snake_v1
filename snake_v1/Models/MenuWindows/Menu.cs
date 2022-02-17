using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace snake_v1.Models.MenuWindows
{
    public abstract class Menu : IMenu
    {
        public Menu(Game game)
        {
            MenuItems = new List<IMenuItem>();

            Console.Clear();
            Console.SetWindowSize(Game.WINDOWWIDTH, Game.WINDOWHIGHT + 1);
            Game = game;

        }
        public virtual IList<IMenuItem> MenuItems { get; set; }
        public Game Game { get; set; }

        public void Draw()
        {
            foreach (var menuItem in MenuItems)
            {
                menuItem.Draw();
            }
        }

        public abstract void Init();

        protected void WrongValue()
        {
            MenuItems.RemoveAt(MenuItems.Count() - 1);
            Console.ForegroundColor = ConsoleColor.Red;

            MenuItems.Add(new MenuItemLabel("Player", 80, TopMargin: 1, MenuItems.Last(), ConsoleColor.Red, $"Введено неверное значение ", Align.left));

            Thread.Sleep(2000);

            Console.ResetColor();
        }
    }
}
