using snake_v1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }
        internal MoveDirection CurrentDirectionPoint { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(int x, int y, char symbol)
              : this(x, y)
        {
            Symbol = symbol;
        }

        public Point(int x, int y, char symbol, MoveDirection currentDirectionPoint) 
              : this(x, y, symbol)
        {
            CurrentDirectionPoint = currentDirectionPoint;
        }

        public void Move(MoveDirection direction,int count)
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

        public void Drow()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }
    }
}
