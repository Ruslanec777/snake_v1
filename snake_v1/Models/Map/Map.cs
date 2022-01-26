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
        public int Height { get; set; }

        public int Width { get; set; }

        public string Name { get; set; }

        public Map(int x, int y, string name, IGeometricPrimitive figur)
             : base(x, y, figur)
        {
            Name = name;
        }
    }
}
