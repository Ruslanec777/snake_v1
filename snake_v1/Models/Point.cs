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
        /// <summary>
        /// Текущее направление движения звена змейки
        /// </summary>
        public MoveDirection CurrentDirectionPoint;

        public Point(int x, int y, char symbol='+')
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public void Move(MoveDirection direction,int count)
        {
            switch (direction)
            {
                case MoveDirection.Up:
                    Y += count;
                    break;
                case MoveDirection.Right:
                    X += count;
                    break;
                case MoveDirection.Down:
                    Y -= count;
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
