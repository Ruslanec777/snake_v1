using snake_v1.Enums;
using System;

namespace snake_v1.Infrastructure
{
    interface IMapGenerator
    {
        IMap Generate(MapType type, int x, int y, int height, int width, ConsoleColor color);
    }
}
