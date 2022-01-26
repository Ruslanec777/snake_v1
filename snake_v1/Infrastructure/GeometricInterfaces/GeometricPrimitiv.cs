using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public abstract class GeometricPrimitiv : IGeometricPrimitive
    {
        public List<IPoint> Points { get; set; } = new();

        public Vector2D OffSet { get; set; } = new(0, 0);

        public void AddOfset(int x, int y)
        {
            OffSet.X = x;
            OffSet.X = y;

            foreach (var point in Points)
            {
                point.X += x;
                point.Y += y;
            }
        }
    }
}
