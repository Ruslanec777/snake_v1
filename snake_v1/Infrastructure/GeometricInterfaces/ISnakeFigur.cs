using snake_v1.Enums;

namespace snake_v1.Infrastructure.GeometricInterfaces
{
    internal interface ISnakeFigur
    {
        public int SnakeLength { get; set; }

        public void TransformMotionSimulation(MoveDirection direction);
    }
}
