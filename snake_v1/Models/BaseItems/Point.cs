﻿using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;

namespace snake_v1.Models.BaseItems
{
    public class Point : IPoint, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }
        public ConsoleColor Color { get; set; }
        public MoveDirection LastMove { get; set; }

        public Point()
        {
        }

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

        public Point(int x, int y, char symbol, ConsoleColor color)
              : this(x, y, symbol)
        {
            Color = color;
        }

        public Point(int x, int y, ConsoleColor color)
              : this(x, y)
        {
            Color = color;
        }

        public Point(char symbol)
        {
            Symbol = symbol;
        }

        public Point(char symbol, ConsoleColor color) : this(symbol)
        {
            Color = color;
        }

        public Point(ConsoleColor color)
        {
            Color = color;
        }

        public void Move(MoveDirection direction, int count)
        {
            LastMove = direction;

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

        public void MoveBack(MoveDirection direction, int count)
        {
            LastMove = direction;

            switch (direction)
            {
                case MoveDirection.Up:
                    Y += count;
                    break;
                case MoveDirection.Right:
                    X -= count;
                    break;
                case MoveDirection.Down:
                    Y -= count;
                    break;
                case MoveDirection.Left:
                    X += count;
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

        public void Draw()
        {
            Console.ForegroundColor = Color;

            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);

            Console.ResetColor();
        }

        public bool IsHit(IPoint point)
        {
            return X == point.X && Y == point.Y;
        }
    }
}
