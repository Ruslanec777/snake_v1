using snake_v1.Enums;
using snake_v1.Infrastructure.GeometricInterfaces;
using snake_v1.Models.BaseItems;
using snake_v1.Models.GeometricPrimitives;
using System;
using System.Collections.Generic;

namespace snake_v1.Infrastructure
{
    /// <summary>
    /// Умеет рисовать объект и удалять ,принимает цвет
    /// </summary>
    public abstract class GameObject :  IGameObject
    {
        private List<IPoint> tempPoints;

        //TODO преобразовать в метод
        public virtual List<IPoint> Points
        {
            get
            {
                tempPoints = new List<IPoint>();

                foreach (var pointTemp in Figur.Points)
                {
                    IPoint point = (IPoint)pointTemp.Clone();

                    point.X = point.X+ Figur.OffSet.X + StartPoint.X;
                    point.Y = point.Y+ Figur.OffSet.Y + StartPoint.Y;
                    point.Color = Figur.Color;

                    tempPoints.Add(point);
                }
                return tempPoints;
            }
        set { }
        }

        public IGeometricPrimitive Figur { get; set; } //= new Line(23, LineType.Horizontal);

        public IPoint StartPoint { get; set; }
        public ConsoleColor Color { get; set; }

        public GameObject()
        {
            //TODO не понятное исключение
            Points = new List<IPoint>();
            Figur = new PointGeomPrimit(ConsoleColor.Black ,' ');
        }
        //TODO GameObject имеет 2 StartPoint !!! snake_v1.Infrastructure.IPoint -		StartPoint (snake_v1.Infrastructure.GameObject)	{snake_v1.Models.BaseItems.Point}	snake_v1.Infrastructure.IPoint {snake_v1.Models.BaseItems.Point}


        public GameObject(int x, int y) : this()
        {
            StartPoint = new Point();
            StartPoint.X = x;
            StartPoint.Y = y;
        }

        public GameObject(int x, int y, IGeometricPrimitive figur)
                   : this(x, y)
        {
            Figur = figur;

          //  InicialPoints(Figur.Points);
        }


        public GameObject(int x, int y, IGeometricPrimitive figur, char symbol)
                   : this(x, y, figur)
        {
            StartPoint.Symbol = symbol;
        }

        public GameObject(int x, int y, IGeometricPrimitive figur, char symbol, ConsoleColor color)
                   : this(x, y, figur, symbol)
        {
            StartPoint.Color = color;
        }

        protected void InicialPoints(List<IPoint> points)
        {
            foreach (var point in points)
            {
                point.X += StartPoint.X;
                point.Y += StartPoint.Y;

                Points.Add(point);
            }
        }

        public virtual void Draw()
        {
            if (Figur.Points.Count == 0)
            {
                return;
            }
            ConsoleColor tempConsoleColor = Console.ForegroundColor;

            Console.ForegroundColor = Color;
            // TODO меняется ли сам Figur?
            //foreach (var point in Points)
            //{
            //    point.X += StartPoint.X;
            //    point.Y += StartPoint.Y;
            //    point.Draw();
            //}

            foreach (var point in Points)
            {
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

        public virtual void Move(MoveDirection direction, int count)
        {
            foreach (var point in Points)
            {
                point.Move(direction, count);
            }
        }
    }
}
