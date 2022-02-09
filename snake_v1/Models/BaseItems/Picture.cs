using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.GeometricPrimitives;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = snake_v1.Models.GeometricPrimitives.Rectangle;

namespace snake_v1.Models.BaseItems
{
    ////TODO уточнить правильность заполнения IClonable<Picture>
    public class Picture : GameObject ,ICloneable
    {
        public Picture()
        {
        }

        public Picture(int x, int y) : base(x, y)
        {
        }

        public Picture(int x, int y, IGeometricPrimitive figur) : base(x, y, figur)
        {
        }

        public Picture(int x, int y, IGeometricPrimitive figur, char symbol) : base(x, y, figur, symbol)
        {
        }

        public Picture(int x, int y, IGeometricPrimitive figur ,ConsoleColor color) : base(x, y, figur)
        {
            Figur.Color = color;
            Color = color;
        }

        public Picture(int x, int y, IGeometricPrimitive figur, char symbol, ConsoleColor color) : base(x, y, figur, symbol, color)
        {
        }

        public Picture(Vector2D startPoint, Vector2D widthHeight, ConsoleColor color) : base(startPoint.X, startPoint.Y, new Rectangle(widthHeight ,color))
        {
            Figur.Color = color;
            Color = color;
        }






        public object Clone()
        {
            return new Picture(StartPoint.X, StartPoint.Y, Figur);
        }

        //public object Clone()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
