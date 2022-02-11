using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using snake_v1.Models.GeometricPrimitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.Map
{
    public static class MapGenerator
    {
        //TODO почему невозможна реализация игтерфейса статическими методами?
        //private static readonly char _verticalChar = (char)9553;
        //private static readonly char _horizontalChar = (char)9552;

        public static Map Generate(MapType type, int x, int y, int width, int height, ConsoleColor color)
        {
            Map map = default;

            switch (type)
            {
                case MapType.Box:
                    map = GenerateBox(x, y, width-(x*2)-1, height-(5+x), color);
                    break;
            }
            return map;
        }

        private static Map GenerateBox(int x, int y, int width, int height, ConsoleColor color)
        {
            IRectangle borders = new Rectangle(width, height, color);

            var map= new Map(x, y, "Box", borders);

            map.BottomLeftEdge = new Vector2D(x, y + height);

            map.BottomRightEdge = new Vector2D(x+width, y + height);

            return map;
        }
    }
}


