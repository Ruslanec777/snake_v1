using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.GameItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.Map
{
    class MapGenerator: IMapGenerator
    {
        private int _x;
        private int _y;

        private readonly char _verticalChar = (char)9553;
        private readonly char _horizontalChar = (char)9552;
        public IMap Generate(MapType type, int height, int width, int x, int y)
        {
            _x = x;
            _y = y;

            IMap map= null;

            switch (type)
            {
                case MapType.Box:
                    map= GenerateBox(height, width);
                    break;

            }
            return map;

        }

        private IMap GenerateBox(int height, int width)
        {
            var upWall = new Line(_x, _y, width, _verticalChar, LineType.Horizontal, ConsoleColor.Red);
            var downWall = new Line(_x, _y + height, width, _verticalChar, LineType.Horizontal, ConsoleColor.Red);
            var leftWall = new Line(_x, _y, height, _horizontalChar, LineType.Horizontal, ConsoleColor.Red);
            var rightWall = new Line(_x + width, _y, height, _horizontalChar, LineType.Horizontal, ConsoleColor.Red);

            var walls = new List<GameObject>() { upWall, downWall, leftWall, rightWall };

            return new Map("Box" ,height,width, walls);
        }
    }
}

// v (char)9553
// h (char)9552

