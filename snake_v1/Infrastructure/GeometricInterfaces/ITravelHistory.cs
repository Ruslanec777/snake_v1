using snake_v1.Enums;

namespace snake_v1.Infrastructure.GeometricInterfaces
{
    public interface ITravelHistory
    {
        public MoveDirection LastMove { get; set; }
    }
}
