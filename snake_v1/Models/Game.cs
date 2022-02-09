using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using snake_v1.Models.GeometricPrimitives;
using snake_v1.Models.Map;
using snake_v1.Models.Menu;
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
        private const byte WINDOWWIDTH = 100;
        // TODO как присвоить тип интерфейса ?
        private static MenuItem _tempMenu;

        public static void Stert()
        {
            // InitMainMenu();

            _tempMenu = new MenuItem(80, 3, ConsoleColor.Green, "drdurdutfyfy");
            _tempMenu.Draw();

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

        private static void InitMainMenu()
        {
            throw new NotImplementedException();
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
            }
        }

        private static void initGame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            currentDirection = Enums.MoveDirection.Right;
            Console.SetWindowSize(WINDOWWIDTH, WINDOWHIGHT+1);

            //_tempMenu = new MenuItem(0, 0, WINDOWWIDTH-1, 4, ConsoleColor.Blue, "Prob prob");
            //_tempMenu.Draw();


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
