using System;

namespace snake_v1.Infrastructure.GeometricInterfaces
{
    public interface IGameObject : IDeleteble, IMovable, IDrawble, IStartPoint
    {
        public IGeometricPrimitive Figur { get; set; }

        //public IPoint StartPoint { get; set; }

        public ConsoleColor Color { get; set; }

    }
}
