using snake_v1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    interface IMapGenerator
    {
        IMap Generate(MapType type, int height, int width, int x, int y);
    }
}
