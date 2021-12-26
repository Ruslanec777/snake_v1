using System;
using System.Threading;
using static snake_v1.Models.Direction;
using static snake_v1.Models.Snake;
using static snake_v1.Models.GameSpeedController;

namespace snake_v1.Models
{
    static class Game
    {
        private static Snake _snake;

        public static void Stert()
        {

            initGame();

            while (true)
            {
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
            Console.SetWindowSize(100, 50);
            initSnake();

        }

        private static void initSnake()
        {
            var teil = new Point(20, 20, '*', ConsoleColor.Green);
            _snake = new Snake(teil, 5, Enums.MoveDirection.Right);
            _snake.Draw();
        }
    }
}
