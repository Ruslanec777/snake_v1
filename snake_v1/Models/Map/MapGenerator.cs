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
    class MapGenerator : IMapGenerator
    {
        private int _x;
        private int _y;

        private readonly char _verticalChar = (char)9553;
        private readonly char _horizontalChar = (char)9552;

        public IMap Generate(MapType type, int height, int width, int x, int y)
        {
            _x = x;
            _y = y;

            IMap map = null;

            switch (type)
            {
                case MapType.Box:
                    map = GenerateBox(height, width);
                    break;
            }
            return map;

        }

        private IMap GenerateBox(int height, int width)
        {
            var upWall = new Line(_x + 1, _y, width, _horizontalChar, LineType.Horizontal, ConsoleColor.Red);
            var rightWall = new Line(_x + width, _y + 1, height, _verticalChar, LineType.Vertical, ConsoleColor.Red);
            var downWall = new Line(_x, _y + height, width, _horizontalChar, LineType.Horizontal, ConsoleColor.Red);
            var leftWall = new Line(_x, _y + 1, height, _verticalChar, LineType.Vertical, ConsoleColor.Red);

            var anglRightDown = new Angl(_x, _y, AngleType.RightDown, ConsoleColor.Red);
            var anglLeftDown = new Angl(_x + width, _y, AngleType.LeftDown, ConsoleColor.Red);
            var anglLeftUp = new Angl(_x + width, _y + height, AngleType.LeftUp, ConsoleColor.Red);
            var anglRightUp = new Angl(_x, _y + height, AngleType.RightUp, ConsoleColor.Red);

            //var mapElements = new List<GameObject>() {anglRightDown, anglLeftDown, anglLeftUp, anglRightUp };
            var mapElements = new List<GameObject>() { upWall, downWall, leftWall, rightWall, anglRightDown, anglLeftDown, anglLeftUp, anglRightUp };

            return new Map("Box", height, width, mapElements);
        }
    }
}

// v (char)9553
// h (char)9552

