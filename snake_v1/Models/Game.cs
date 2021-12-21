using System;
using System.Threading;
using static snake_v1.Models.Direction;
using static snake_v1.Models.MainSnake;

namespace snake_v1.Models
{
    class Game
    {
        public static void Stert()
        {
            Console.CursorVisible = false;
            Point point = new Point(5, 20, '+');


            while (true)
            {
                Console.Clear();
                //Console.Clear();
                if (Console.KeyAvailable)
                {
                    ChangeDirection(Console.ReadKey().Key);
                }

                SnakeMove();
                Thread.Sleep(60);

            }
        }
    }
}
