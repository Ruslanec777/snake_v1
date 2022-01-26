using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using snake_v1.Models.GeometricPrimitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    /// <summary>
    /// Умеет рисовать объект и удалять ,принимает цвет
    /// </summary>
    public class GameObject<T> : IPoint where T : IPoint
    {
        public GeometricPrimitiv Figur { get; set; } //= new Line(23, LineType.Horizontal);
        public GameObject(int x, int y)
        {
            X = x;
            Y = y;
        }

        public GameObject(int x, int y,IGeometricPrimitive figur)
                   : this(x, y)
        {
            Figur = (GeometricPrimitiv)figur;

            //Figur.Points.Add(new Point());

            InicialPoints(Figur.Points); //TODO Разобрать почему не получается
        }
        //TODO разобрать почему не проходит
        //private void InicialPoints(List<T> points)
        private void InicialPoints(List<IPoint> points)
        {
            foreach (var point in points)
            {
                point.X += X;
                point.Y += Y;
                // так работает :
                //Points.Add((T)point);
                //так не работает:
                Points.Add(point);
            }
        }

        public GameObject(int x, int y, IGeometricPrimitive figur, char symbol)
                   : this(x, y, figur)
        {
            Symbol = symbol;
        }

        public GameObject(int x, int y, IGeometricPrimitive figur, char symbol, ConsoleColor color)
                   : this(x, y, figur, symbol)
        {
            Color = color;
        }

        //protected ConsoleColor _color;
        public int X { get; set; }

        public int Y { get; set; }

        public List<T> Points { get; set; } = new();
        public char Symbol { get; }
        public ConsoleColor Color { get; set; }
        //TODO как написать автосвойство автоматически , из интерфейса , без throw?
        //int IPoint.Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IPoint.X { get; set ; }
        int IPoint.Y { get ; set; }

        public void Draw()
        {
            if (Figur.Points.Count==0)
            {
                return;
            }
            ConsoleColor tempConsoleColor = Console.ForegroundColor;

            Console.ForegroundColor = Color;
            // TODO меняется ли сам Figur?
            foreach (var point in Figur.Points)
            {
                point.X += X;
                point.Y += Y;
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


        //public bool IsHit(IPoint point)
        //{

        //    return _points.Any(x => x.IsHit(point));
        //    // расписать forEach
        //}
        //}

        //public bool IsHit(IRigidBody gameObject)
        //{
        //    return _points.Any(x => gameObject.IsHit(x));
    }
}
