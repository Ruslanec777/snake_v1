using snake_v1.Models.BaseItems;

namespace snake_v1.Infrastructure
{
    public interface IDisplaceable
    {
        public Vector2D OffSet { get; set; }

        //TODO добавил реализацию в интерфейс
        public void AddOfset(int x, int y);
    }
}
