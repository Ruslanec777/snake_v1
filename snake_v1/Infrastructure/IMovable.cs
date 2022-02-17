using snake_v1.Enums;

namespace snake_v1.Infrastructure
{
    public interface IMovable
    {
        public void Move(MoveDirection direction, int count);
    }
}
