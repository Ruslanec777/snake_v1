using snake_v1.Enums;
using snake_v1.Models.BaseItems;
using System;
using System.Linq;
using System.Threading;

namespace snake_v1.Models.MenuWindows
{
    internal class MenuPlayerChange : Menu
    {
        private string _returnedValue;

        public MenuPlayerChange(Game game) : base(game)
        {
            Init();
        }

        public override void Init()
        {
            Console.Clear();

            MenuItems.Clear();

            MenuItems.Add(new MenuItemLabel("Header", 95, 1, ConsoleColor.Red, "Змейка"));

            MenuItems.Add(new MenuItemLabel("Player", 80, TopMargin: 2, MenuItems.Last(), ConsoleColor.Blue, $" Игрок : {Game.Nic}", Align.left));

            Draw();

            MenuItems.Add(new MenuItemInput("ChangName", MenuItems.Last().BottomLeftEdge.Sum(new Vector2D(0, 1)), new Vector2D(30, 3),
              ConsoleColor.Red, "Введите имя", ref _returnedValue, Align.left));

            Game.Nic = _returnedValue;

            MenuItems.Where(x => x.Name == "Player").ToArray()[0].Text = "";
            MenuItems.Where(x => x.Name == "Player").ToArray()[0].Text = "Игрок  :" + _returnedValue;

            Thread.Sleep(3000);

        }
        //Console.ReadKey();
    }
}

