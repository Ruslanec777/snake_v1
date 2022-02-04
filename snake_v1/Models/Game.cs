using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using snake_v1.Models.GeometricPrimitives;
using snake_v1.Models.Map;
using System;
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

        private static bool _gameOver=default;

        private static bool _directionChaged = false;
        private const byte WINDOWHIGHT = 30;
        private const byte WINDOWWIDTH = 30;

        public static void Stert()
        {

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
                    Console.SetCursorPosition(3, 2);
                    Console.WriteLine("Game Over");
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
            if (map.IsHit(snake.Head) /*|| snake.IsHit(snake.Head)*/)
            {
                _gameOver = true;
            }

            if (map.Frut.IsHit(snake.Head))
            {
                snake.SnakeAddItem();
                map.Frut.Delete();
                map.GenerateNewFruit();
            }


        }

        private static void initGame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            currentDirection = Enums.MoveDirection.Right;
            Console.SetWindowSize(WINDOWWIDTH+1, WINDOWHIGHT+1);


            map = MapGenerator.Generate(Enums.MapType.Box, 1, 4, WINDOWWIDTH, WINDOWHIGHT, ConsoleColor.Yellow);
            map.Draw();
            map.GenerateNewFruit();

            initSnake();
        }

        private static void initSnake()
        {
            //var teil = new Point(20, 20, '*', ConsoleColor.Green);
            snake = new Snake(20, 20, 5, MoveDirection.Left, ConsoleColor.Green);
            snake.Draw();
        }


    }
}
