using snake_v1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public abstract class GeometricFigure : IPoint
    {
        public List<IPoint> Points { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get ; set ; }
        public ConsoleColor Color { get; set; } = ConsoleColor.White;
        public GeometricFigure(int x, int y)
        {
            X = x;
            Y = y;
        }
        protected GeometricFigure(int x, int y, char symbol)
                           : this(x, y)
        {
            Symbol = symbol;
        }
        protected GeometricFigure(int x, int y, char symbol, ConsoleColor color)
                           : this(x, y, symbol)
        {
            Color = color;
        }
        virtual public void Delete()
        {
            foreach (var point in Points)
            {
                point.Delete();
            }
        }
        virtual public void Draw()
        {
            foreach (var point in Points)
            {
                point.Draw();
            }
        }
        public void Move(MoveDirection direction, int count)
        {
            throw new NotImplementedException();
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public bool IsHit(IPoint point)
        {
            throw new NotImplementedException();
        }
    }
}
