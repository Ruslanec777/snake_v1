using System;
using System.Threading;
using static snake_v1.Models.Direction;
using static snake_v1.Models.MainSnake;
using static snake_v1.Models.GameSpeedController;

namespace snake_v1.Models
{
    class Game
    {
        public static void Stert()
        {
            Console.Clear();
            Console.CursorVisible = false;
            currentDirection = Enums.MoveDirection.Right;
            MainSnakeInical();

            while (true)
            {
                Console.CursorVisible = false;

                //Console.Clear();
                if (Console.KeyAvailable)
                {
                    ChangeDirection(Console.ReadKey().Key);
                }

                SnakeMove();

                ControlledPause();

            }
        }
    }
}
