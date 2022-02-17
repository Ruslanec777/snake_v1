using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;

namespace snake_v1.Models.GeometricPrimitives
{
    internal class PointGeomPrimit : GeometricPrimitiv
    {
        public PointGeomPrimit()
        {
        }

        public PointGeomPrimit(List<IPoint> points) : base(points)
        {
        }

        public PointGeomPrimit(List<IPoint> points, Vector2D offSet) : base(points, offSet)
        {
        }

        public PointGeomPrimit(ConsoleColor color, char symbol) : this()
        {
            Color = color;
            Points.Add(new Point(symbol));
        }
    }
}
