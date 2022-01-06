using System;
using System.Threading;
using static snake_v1.Models.Direction;
using static snake_v1.Models.Snake;
using static snake_v1.Models.GameSpeedController;
using System.Collections.Generic;
using snake_v1.Infrastructure;
using System.Drawing;
using snake_v1.Models.Map;

namespace snake_v1.Models
{
    static class Game
    {
        private static Snake _snake;

        private  const byte _windowHeight= 40;
        private const byte _windowWidth= 100;

        private static IMap _map;

        private static IMapGenerator _mapGenerator;

        private static IMenu _menu;

        static Game()
        {
            _mapGenerator = new MapGenerator();
        }
        


        public static void Stert()
        {

            initGame();

            while (true)
            {
                Console.CursorVisible = false;
                _snake.Move();

                //Console.Clear();
                if (Console.KeyAvailable)
                {
                    _snake.ChangeDirection(Console.ReadKey(true).Key);
                }
                ControlledPause();

            }
        }

        private static void initGame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            currentDirection = Enums.MoveDirection.Right;

            Console.SetWindowSize(_windowWidth, _windowHeight);

            //Console.SetWindowSize(50, 30);
            initSnake();
            initMap();

        }

        private static void initSnake()
        {
            var teil = new Point(20, 20, '*', ConsoleColor.Green);
            _snake = new Snake(teil, 5, Enums.MoveDirection.Right);
            _snake.Draw();
        }

        private static void initMap()
        {
            _map = _mapGenerator.Generate(Enums.MapType.Box, 30, 90, 5, 5);
            _map.Draw();
        }

    }
}
