using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using snake_v1.Models.History;
using snake_v1.Models.Map;
using snake_v1.Models.MenuWindows;
using System;
using System.Collections.Generic;
using System.Threading;
using static snake_v1.Models.Direction;
//TODO вернуть 
//using static snake_v1.Models.Snake;
using static snake_v1.Models.GameSpeedController;

namespace snake_v1.Models
{
    static class Game
    {
        public static Snake snake;

        public static IMap map;

        public static string Nic = "Player";

        private static bool _gameOver = default;

        private static List<IMenuItem> _menuItems;

        private static string _fileName="Save.txt";



        private static int _score = 0;

        private static IMenuItem _nicMenuItem;
        private static IMenuItem _scoreMenuItem;
        private static IMenuItem _mapMeuItem;


        internal const byte WINDOWWIDTH = 100;
        internal const byte WINDOWHIGHT = 40;

        internal static readonly byte _menuItemHight = 5;
        internal static readonly byte _menuItemWidth = 20;

        public static void Stert()
        {

            //TODO убрать
            GameHistory gameHistory = new GameHistory(_fileName);

            return;

            IMenu menu = new MainMenu();

            initGame();

            while (true)
            {
                Console.CursorVisible = false;

                if (Console.KeyAvailable)
                {
                    snake.ChangeDirection(Console.ReadKey(true).Key);
                }

                snake.Move();

                TouchCheck();

                if (_gameOver)
                {
                    MenuItemLabel menuItemLabel = new MenuItemLabel("GameOver", new Vector2D(WINDOWWIDTH / 2 - _menuItemWidth / 2, 0), new Vector2D(_menuItemWidth, _menuItemHight), ConsoleColor.Red, "Игра окончена");

                    for (int i = 0; i < 10; i++)
                    {
                        menuItemLabel.Color = ConsoleColor.Blue;
                        menuItemLabel.Draw();

                        Thread.Sleep(500);

                        menuItemLabel.Color = ConsoleColor.White;
                        menuItemLabel.Draw();

                        Thread.Sleep(500);
                    }
                    Console.ReadLine();
                    break;
                }

                snake.Draw();
                //Thread.Sleep(400);

                //Console.Clear();
                ControlledPause();
            }
        }

        private static void TouchCheck()
        {

            if (map.IsHit(snake.Head) || snake.IsHitTail())
            {
                _gameOver = true;
            }

            if (map.Frut.IsHit(snake.Head))
            {
                snake.SnakeAddItem();
                map.Frut.Delete();
                map.GenerateNewFruit();
                _score += 1;
                _scoreMenuItem.Text = "Очки: " + _score.ToString();
            }
        }

        private static void initGame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            currentDirection = Enums.MoveDirection.Right;
            Console.SetWindowSize(WINDOWWIDTH, WINDOWHIGHT + 1);

            map = MapGenerator.Generate(Enums.MapType.Box, 16, 10, WINDOWWIDTH, WINDOWHIGHT, ConsoleColor.Yellow);
            map.Draw();
            map.GenerateNewFruit();

            _menuItems = new();

            _nicMenuItem = new MenuItemLabel("Name", new Vector2D(1, 0), new Vector2D(_menuItemWidth, _menuItemHight), ConsoleColor.Red, "Игрок:" + Nic);

            _scoreMenuItem = new MenuItemLabel("Score", new Vector2D(1, WINDOWHIGHT - _menuItemHight), new Vector2D(20, 5), ConsoleColor.Red, "Очки:" + _score.ToString());

            _mapMeuItem = new MenuItemLabel("Map", new Vector2D(WINDOWWIDTH - _menuItemWidth, 0), new Vector2D(_menuItemWidth, _menuItemHight), ConsoleColor.Red, "Карта :" + map.Name);

            _menuItems.Add(_nicMenuItem);
            _menuItems.Add(_scoreMenuItem);
            _menuItems.Add(_mapMeuItem);


            foreach (var item in _menuItems)
            {
                item.Draw();
            }

            initSnake();
        }

        private static void initSnake()
        {
            snake = new Snake(map.StartPoint.X + map.Width / 2, map.StartPoint.Y + map.Height / 2, 5, MoveDirection.Left, ConsoleColor.Green);
            snake.Draw();
        }
    }
}
