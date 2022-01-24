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
    internal class RigidBody : GameObject<IRigidPoint>, IClonable<RigidBody>, IRigidBody
    {
        //public RigidBody(Picture geometricFigure)
        //          : base(geometricFigure.X, geometricFigure.Y, geometricFigure.Symbol, geometricFigure.Color)
        //{
        //}

        //public List<RigidPoint> Points
        //{
        //    get
        //    {
        //        List<RigidPoint> rigidPoints = new List<RigidPoint>();

        //        foreach (var point in Points)
        //        {
        //            rigidPoints.Add(new RigidPoint(point));
        //        }

        //        return rigidPoints;
        //    }
        //}

        //public int X => throw new NotImplementedException();

        //public int Y => throw new NotImplementedException();

        //public ConsoleColor Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public char Symbol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //List<IRigidPoint> IRigidBody.Points => throw new NotImplementedException();


        //public bool IsHit(RigidBody rigidBody)
        //{
        //    return Points.Any(x => rigidBody.IsHit(x));
        //}

        //public bool IsHit(RigidPoint point)
        //{
        //    return Points.Any(pnt => point.IsHit(pnt));
        //}
        public RigidBody(int x, int y) : base(x, y)
        {
        }

        public RigidBody(int x, int y, List<IRigidPoint> points) : base(x, y, points)
        {
        }

        public RigidBody(int x, int y, List<IRigidPoint> points, char symbol) : base(x, y, points, symbol)
        {
        }

        public RigidBody(int x, int y, List<IRigidPoint> points, char symbol, ConsoleColor color) : base(x, y, points, symbol, color)
        {
        }

        // TODO проверить
        public RigidBody Clon()
        {
            return new RigidBody(X, Y, Points, Symbol, Color);
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
