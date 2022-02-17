using snake_v1.Infrastructure.GeometricInterfaces;

namespace snake_v1.Infrastructure
{
    public interface IRigidBody : IGameObject
    {
        // public List<IRigidPoint> Points { get; }

        public bool IsHit(IRigidBody rigidBody);

        public bool IsHit(IPoint point);

        //public bool IsHit(IRigidPoint rigidPoint);
    }
}
