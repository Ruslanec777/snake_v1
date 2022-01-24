using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.Map
{
    public class Map : RigidBody, IMap
    {
        public int Height { get; private set; }

        public int Width { get; private set; }

        public string Name { get; private set; }

        public ConsoleColor Color { get; }

        public Map(int x, int y, string name, List<IPoint> geometricFigure)
            : base(x, y, geometricFigure)
        {
            Name = name;
        }
    }
}
