using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using snake_v1.Models.GeometricFigurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.Map
{
    class MapGenerator : IMapGenerator
    {
        private readonly char _verticalChar = (char)9553;
        private readonly char _horizontalChar = (char)9552;

        public IMap Generate(MapType type, int x, int y, int height, int width, ConsoleColor color)
        {
            IMap map = null;

            switch (type)
            {
                case MapType.Box:
                    map = GenerateBox(x, y, height, width, color);
                    break;
            }
            return map;
        }

        private IMap GenerateBox(int x, int y, int height, int width, ConsoleColor color)
        {
            //var upWall = new Line(_x + 1, _y, width, LineType.Horizontal, ConsoleColor.Red);
            //var rightWall = new Line(_x + width, _y + 1, height, LineType.Vertical, ConsoleColor.Red);
            //var downWall = new Line(_x, _y + height, width, LineType.Horizontal, ConsoleColor.Red);
            //var leftWall = new Line(_x, _y + 1, height, LineType.Vertical, ConsoleColor.Red);

            //var anglRightDown = new Angl(_x, _y, AngleType.RightDown, ConsoleColor.Red);
            //var anglLeftDown = new Angl(_x + width, _y, AngleType.LeftDown, ConsoleColor.Red);
            //var anglLeftUp = new Angl(_x + width, _y + height, AngleType.LeftUp, ConsoleColor.Red);
            //var anglRightUp = new Angl(_x, _y + height, AngleType.RightUp, ConsoleColor.Red);

            ////var mapElements = new List<GeometricFigure>() { anglRightDown, anglLeftDown, anglLeftUp, anglRightUp };


            //var borders = new List<GeometricFigure>() { upWall, downWall, leftWall, rightWall, anglRightDown, anglLeftDown, anglLeftUp, anglRightUp };
            ////List<GeometricFigure> borders = new GameObject(new Rectangle(_x, _y, height, width, ConsoleColor.Red));

            Picture borders = new Rectangle(x, y, height, width, color);
            return new Map(x, y, "Box", borders);
        }
    }
}


