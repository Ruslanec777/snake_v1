using snake_v1.Enums;
using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;

namespace snake_v1.Infrastructure
{
    /// <summary>
    /// Умеет рисовать объект и удалять ,принимает цвет
    /// </summary>
    public class GameObject<T> : IStartPoint where T : IPoint
    {
        public List<T> Points { get; set; } = new();

        public IGeometricPrimitive<T> Figur { get; set; } //= new Line(23, LineType.Horizontal);
        public IPoint StartPoint { get; set; }

        public GameObject()
        {
        }

        public GameObject(int x, int y)
        {
            StartPoint = new Point ();
            StartPoint.X = x;
            StartPoint.Y = y;
        }

        public GameObject(int x, int y, IGeometricPrimitive<T> figur)
                   : this(x, y)
        {
            Figur = figur;

            //Figur.Points.Add(new Point());

            InicialPoints(Figur.Points ); //TODO Разобрать почему не получается
        }
        //TODO разобрать почему не проходит
        //private void InicialPoints(List<T> points)
        private void InicialPoints(List<T> points)
        {

            foreach (var point in points)
            {
                point.X += StartPoint.X;
                point.Y += StartPoint.Y;

                Points.Add(point);

            }
        }

        public GameObject(int x, int y, IGeometricPrimitive<T> figur, char symbol)
                   : this(x, y, figur)
        {
            StartPoint.Symbol = symbol;
        }

        public GameObject(int x, int y, IGeometricPrimitive<T> figur, char symbol, ConsoleColor color)
                   : this(x, y, figur, symbol)
        {
            StartPoint.Color = color;
        }

        //protected ConsoleColor _color;


        public void Draw()
        {
            if (Figur.Points.Count == 0)
            {
                return;
            }
            ConsoleColor tempConsoleColor = Console.ForegroundColor;

            Console.ForegroundColor = StartPoint.Color;
            // TODO меняется ли сам Figur?
            foreach (var point in Figur.Points)
            {
                point.X += StartPoint.X;
                point.Y += StartPoint.Y;
                point.Draw();
            }

            Console.ResetColor();
            Console.ForegroundColor = tempConsoleColor;
        }

        public void Delete()
        {
            foreach (var point in Points)
            {
                point.Delete();
            }
        }

        public void Move(MoveDirection direction, int count)
        {
            foreach (var point in Points)
            {
                point.Move(direction, count);
            }
        }
    }
}
