using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.BaseItems
{
    ////TODO уточнить правильность заполнения IClonable<Picture>
    public class Picture : GameObject<IPoint> ,IClonable<Picture>
    {
        protected Picture(int x, int y) 
                   : base(x, y)
        {
        }

        protected Picture(int x, int y, List<IPoint> points) 
                   : base(x, y, points)
        {
        }

        protected Picture(int x, int y, List<IPoint> points, char symbol)
                   : base(x, y, points, symbol)
        {
        }

        protected Picture(int x, int y, List<IPoint> points, char symbol, ConsoleColor color) 
                   : base(x, y, points, symbol, color)
        {
        }
        // TODO правильно ли указано возвращаемое значение в соответствии с T?
        public Picture Clon()
        {
            return new Picture(X, Y, Points, Symbol, Color);
        }


        //public List<Point> Points { get; set; }

        //public int X { get; set; }
        //public int Y { get; set; }
        //public char Symbol { get; set; }
        //public ConsoleColor Color { get; set; } = ConsoleColor.White;
        //public Picture(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //}
        //protected Picture(int x, int y, char symbol)
        //                   : this(x, y)
        //{
        //    Symbol = symbol;
        //}
        //protected Picture(int x, int y, char symbol, ConsoleColor color)
        //                   : this(x, y, symbol)
        //{
        //    Color = color;
        //}

        //public Picture(int x, int y, List<Picture> geometricFigures)
        //    : this(x, y)
        //{
        //    foreach (var geometricFigure in geometricFigures)
        //    {
        //        Points.AddRange((IEnumerable<Point>)geometricFigure);
        //    }
        //}


        //virtual public void Delete()
        //{
        //    foreach (var point in Points)
        //    {
        //        point.Delete();
        //    }
        //}
        //virtual public void Draw()
        //{
        //    foreach (var point in Points)
        //    {
        //        point.Draw();
        //    }
        //}
        //public void Move(MoveDirection direction, int count)
        //{
        //    throw new NotImplementedException();
        //}
        //public object Clone()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
