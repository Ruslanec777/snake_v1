using snake_v1.Enums;
using snake_v1.Models.BaseItems;
using System;
using System.Linq;
using System.Threading;
using snake_v1.Infrastructure.GeometricInterfaces;

namespace snake_v1.Models.MenuWindows
{
    public class MainMenu : Menu
    {
        public MainMenu() : base()
        {

            Init();
        }



        private string _returnedValue = string.Empty;

        public override void Init()
        {
            while (true)
            {
                Console.Clear();

                MenuItems.Clear();

                MenuItems.Add(new MenuItem("Header", 95, 1, ConsoleColor.Red, "Змейка"));

                MenuItems.Add(new MenuItem("SelectedMap", 80, TopMargin: 1, MenuItems.Last(), Console.BackgroundColor, "Выбранная карта: карта со стенами", Align.left));

                MenuItems.Add(new MenuItem("Play", 80, TopMargin: 0, MenuItems.Last(), ConsoleColor.Green, "1. Играть", Align.left));

                MenuItems.Add(new MenuItem("ChangNic", 80, TopMargin: 0, MenuItems.Last(), ConsoleColor.Green, "2. Смена игрока", Align.left));

                MenuItems.Add(new MenuItem("MapSelect", 80, TopMargin: 0, MenuItems.Last(), ConsoleColor.Green, "3. Выбор карты", Align.left));

                MenuItems.Add(new MenuItem("Reiting", 80, TopMargin: 0, MenuItems.Last(), ConsoleColor.Green, "4 .Таблица рейтинга", Align.left));

                MenuItems.Add(new MenuItem("Exit", 80, TopMargin: 0, MenuItems.Last(), ConsoleColor.Green, "5 .Выход", Align.left));

                MenuItems.Add(new MenuItem("Player", 80, TopMargin: 2, MenuItems.Last(), ConsoleColor.Blue, $" Игрок : {Game.Nic}", Align.left));

                MenuItems.Add(new MenuItem("Space", 80, TopMargin: 1, MenuItems.Last(), Console.BackgroundColor, $"", Align.left));

                Draw();

                int returnedValue;

                MenuItems.Add(new MenuItemInput("SelectMenuItem", MenuItems.Last().BottomLeftEdge.Sum(new Vector2D(0, 1)), new Vector2D(30, 3),
                  ConsoleColor.Red, "Выберете пункт меню", ref _returnedValue, Align.left));

                Thread.Sleep(1000);

                if (!int.TryParse(_returnedValue, out returnedValue))
                {
                    WrongValue();
                    continue;
                }

                switch (returnedValue)
                {
                    case 1:
                        break;

                    case 2:
                        var menuPlayerChange = new MenuPlayerChange();
                        continue;


                    case 3:
                        MenuSelectMap menuSelectMap = new MenuSelectMap();
                        continue;

                    case 4:
                        MenuReiting menuReiting = new MenuReiting();
                        continue;

                    case 5:
                        RequestFromMenu = RequestType.Exit;
                        return;

                    default:
                        WrongValue();
                        continue;
                }
                return;
            }


            //Console.ReadKey();
        }
    }
}
