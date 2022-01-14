using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.GeometricFigurs
{
    public class Point : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; } = ConsoleColor.Black;
        public char Symbol { get; set; } = ' ';

        //public int X => throw new NotImplementedException();

        //public int Y => throw new NotImplementedException();

        public Point(int x, int y)
        {
        }

        public Point(int x, int y, char symbol, ConsoleColor color)
              : this(x, y)
        {
            Symbol = symbol;
            Color = color;
        }

        public void Move(MoveDirection direction, int count)
        {
            switch (direction)
            {
                case MoveDirection.Up:
                    Y -= count;
                    break;
                case MoveDirection.Right:
                    X += count;
                    break;
                case MoveDirection.Down:
                    Y += count;
                    break;
                case MoveDirection.Left:
                    X -= count;
                    break;
                default:
                    break;
            }
        }

        public void Delete()
        {
            Symbol = ' ';
            Draw();
        }

        public object Clone()
        {
            return new Point(X, Y, Symbol, Color);
        }

        public bool IsHit(IPoint point)
        {
            return X == point.X && Y == point.Y;
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;

            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);

            Console.ResetColor();
        }
    }
}
