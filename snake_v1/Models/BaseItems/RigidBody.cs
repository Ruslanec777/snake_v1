using snake_v1.Infrastructure;
using snake_v1.Models.GeometricFigurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.BaseItems
{
    internal class RigidBody : GeometricFigure, IRigidBody
    {
        public RigidBody(GeometricFigure geometricFigure)
                  : base(geometricFigure.X, geometricFigure.Y, geometricFigure.Symbol, geometricFigure.Color)
        {
        }

        private List<RigidPoint> _rigidPoints
        {
            get
            {
                List<RigidPoint> rigidPoints = new List<RigidPoint>();

                foreach (var point in Points)
                {
                    rigidPoints.Add(new RigidPoint(point));
                }

                return rigidPoints;
            }
        }

        public bool IsHit(RigidBody rigidBody)
        {
            return _rigidPoints.Any(x => rigidBody.IsHit(x));
        }

        public bool IsHit(RigidPoint point)
        {
            return _rigidPoints.Any(pnt => point.isHit(pnt));
        }
    }
}
