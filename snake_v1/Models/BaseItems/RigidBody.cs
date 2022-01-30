using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.BaseItems
{
    public class RigidBody : GameObject, IRigidBody, ICloneable
    {
        //TODO разобрать , нужно ли переписывать конструкторы 
        public RigidBody(int x, int y) : base(x, y)
        {
        }

        public RigidBody(int x, int y, IGeometricPrimitive figur) : base(x, y, figur)
        {
            
        }

        public RigidBody(int x, int y, IGeometricPrimitive figur, char symbol) : base(x, y, figur, symbol)
        {
        }

        public RigidBody(int x, int y, IGeometricPrimitive figur, char symbol, ConsoleColor color) : base(x, y, figur, symbol, color)
        {
        }

        private RigidBody(int x, int y, IGeometricPrimitive figur, List<IPoint> points, char symbol, ConsoleColor color) : base(x, y, figur, symbol, color)
        {
            Points = points;
        }

        public object Clone()
        {
            return new RigidBody(StartPoint.X, StartPoint.Y, Figur, Points, StartPoint.Symbol, StartPoint.Color);
        }

        public bool IsHit(IRigidBody rigidBody)
        {
            return Points.Any(point => rigidBody.IsHit(point));
        }

        public bool IsHit(IPoint point)
        {
            return Points.Any(point => this.IsHit(point));
        }


    }
}
