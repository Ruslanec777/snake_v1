﻿using snake_v1.Enums;
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

                MenuItems.Add(new MenuItemLabel("Header", 95, 1, ConsoleColor.Red, "Змейка"));

                MenuItems.Add(new MenuItemLabel("SelectedMap", 80, TopMargin: 1, MenuItems.Last(), Console.BackgroundColor, "Выбранная карта: карта со стенами", Align.left));

                MenuItems.Add(new MenuItemLabel("Play", 80, TopMargin: 0, MenuItems.Last(), ConsoleColor.Green, "1. Играть", Align.left));

                MenuItems.Add(new MenuItemLabel("ChangNic", 80, TopMargin: 0, MenuItems.Last(), ConsoleColor.Green, "2. Смена игрока", Align.left));

                MenuItems.Add(new MenuItemLabel("MapSelect", 80, TopMargin: 0, MenuItems.Last(), ConsoleColor.Green, "3. Выбор карты", Align.left));

                MenuItems.Add(new MenuItemLabel("Reiting", 80, TopMargin: 0, MenuItems.Last(), ConsoleColor.Green, "4 .Таблица рейтинга", Align.left));

                MenuItems.Add(new MenuItemLabel("Exit", 80, TopMargin: 0, MenuItems.Last(), ConsoleColor.Green, "5 .Выход", Align.left));

                MenuItems.Add(new MenuItemLabel("Player", 80, TopMargin: 2, MenuItems.Last(), ConsoleColor.Blue, $" Игрок : {Game.Nic}", Align.left));

                MenuItems.Add(new MenuItemLabel("Space", 80, TopMargin: 1, MenuItems.Last(), Console.BackgroundColor, $"", Align.left));

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
                    case (int)MainMenuItems.Play :
                        break;

                    case (int)MainMenuItems.NicknameСhange:
                        var menuPlayerChange = new MenuPlayerChange();
                        continue;


                    case (int)MainMenuItems.SelectMap:
                        MenuSelectMap menuSelectMap = new MenuSelectMap();
                        continue;

                    case (int)MainMenuItems.LeaderBoard:
                        MenuLeaderBoard menuReiting = new MenuLeaderBoard();
                        continue;

                    case (int)MainMenuItems.Exit:
                        Console.Clear();
                        Environment.Exit(0);
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
