using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.BaseItems
{
    //TODO уточнить правильность заполнения IClonable<RigidBody>
    public class RigidBody : GameObject<IRigidPoint>, ICloneable, IRigidBody
    {
        public RigidBody(int x, int y) : base(x, y)
        {
        }

        public RigidBody(int x, int y, IGeometricPrimitive<IRigidPoint> figur) : base(x, y, figur)
        {
        }

        public RigidBody(int x, int y, IGeometricPrimitive<IRigidPoint> figur, char symbol) : base(x, y, figur, symbol)
        {
        }

        public RigidBody(int x, int y, IGeometricPrimitive<IRigidPoint> figur, char symbol, ConsoleColor color) : base(x, y, figur, symbol, color)
        {
        }

        public object Clone()
        {
            return new RigidBody(StartPoint.X, StartPoint.Y, Figur, StartPoint.Symbol, StartPoint.Color);
        }

        public bool IsHit(IRigidPoint rigidPoint)
        {
            return Points.Any(rigPoint => rigPoint.IsHit(rigidPoint));
        }

        public bool IsHit(IRigidBody rigidBody)
        {
            return Points.Any(rigPoint => rigidBody.IsHit(rigPoint));
        }
    }
}
