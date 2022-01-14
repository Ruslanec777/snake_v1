using snake_v1.Infrastructure;
using snake_v1.Models.GeometricFigurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.Map
{
    class Map :IMap
    {
        public int Height { get;private set; }

        public int Width { get; private set; }

        public string Name { get; private set; }

        public List<GameObject> Walls { get; private set; }

        public Map(string name ,int height ,int width ,List<GameObject> walls)
        {
            Name = name;
            Height = height;
            Width = width;
            Walls = walls;
        }

        public Map(int height, int width, string name, List<Point> points)
        {
        }

        public void Draw()
        {
            foreach (var wall in Walls)
            {
                wall.Draw();
            }
        }

        public bool IsHit(IGameObject gameObject)
        {
            return Walls.Any(x => x.IsHit(gameObject));
        }
    }
}
