using snake_v1.Enums;
using System;

namespace snake_v1.Models
{
    class Direction
    {
        public static MoveDirection currentDirection ;

        public static void ChangeDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.A:
                    if (currentDirection != MoveDirection.Right)
                    {
                        currentDirection = MoveDirection.Left;
                    }
                    break;
                case ConsoleKey.D:
                    if (currentDirection != MoveDirection.Left)
                    {
                        currentDirection = MoveDirection.Right;
                    }
                    break;
                case ConsoleKey.S:
                    if (currentDirection != MoveDirection.Down)
                    {
                        currentDirection = MoveDirection.Down;
                    }
                    break;
                case ConsoleKey.W:
                    if (currentDirection != MoveDirection.Up)
                    {
                        currentDirection = MoveDirection.Up;
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
