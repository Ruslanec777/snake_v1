using snake_v1.Enums;
using snake_v1.Infrastructure.GeometricInterfaces;
using System;

namespace snake_v1.Infrastructure
{
    public interface IPoint : IDrawble, IDeleteble, IMovable, ITravelHistory, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; }
        public char Symbol { get; set; }

        void MoveBack(MoveDirection direction, int count);

        public bool IsHit(IPoint point);
    }
}
