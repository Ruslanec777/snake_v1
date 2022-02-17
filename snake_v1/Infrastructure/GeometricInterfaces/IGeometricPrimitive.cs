using System;
using System.Collections.Generic;

namespace snake_v1.Infrastructure
{
    public interface IGeometricPrimitive : IDisplaceable
    {
        public List<IPoint> Points { get; set; }
        ConsoleColor Color { get; set; }

        void TakeOnFigure(GeometricPrimitiv geometricPrimitiv);
        void TakeOnFigure(IPoint point);
    }
}
