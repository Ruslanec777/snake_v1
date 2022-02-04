using snake_v1.Enums;
using snake_v1.Infrastructure.GeometricInterfaces;
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
        public List<IPoint> Points { get; set; }

        public Vector2D OffSet { get; set; }

        public ConsoleColor Color { get; set; }

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

        protected GeometricPrimitiv()
        {
            Points = new List<IPoint>();
            OffSet = new Vector2D(0, 0);
        }
        //TODO вспомнить , нужно ли тут вызывать конструкор без параметров
        protected GeometricPrimitiv(List<IPoint> points) : this()
        {
            Points = points;
        }

        protected GeometricPrimitiv(List<IPoint> points, Vector2D offSet) : this(points)
        {
            OffSet = offSet;
        }

        public void TakeOnFigure(GeometricPrimitiv geometricPrimitiv)
        {
            //List<IPoint> points = new();

            foreach (var point in geometricPrimitiv.Points)
            {
                point.X += geometricPrimitiv.OffSet.X;
                point.Y += geometricPrimitiv.OffSet.Y;
                Points.Add(point);
            }
            //Points.AddRange(geometricPrimitiv.Points);
        }

        public void TakeOnFigure(IPoint point)
        {
            Points.Add(point);
        }

        public abstract void TransformMotionSimulation(MoveDirection direction);
    }
}
