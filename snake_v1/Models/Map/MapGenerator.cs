﻿using snake_v1.Enums;
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
            Map map = null;

            switch (type)
            {
                case MapType.Box:
                    map = GenerateBox(x, y, width+1-(x*2), height-(5+x), color);
                    break;
            }
            return map;
        }

        private static Map GenerateBox(int x, int y, int width, int height, ConsoleColor color)
        {
            IRectangle borders = new Rectangle(width, height, color);

            return new Map(x, y, "Box", borders);
        }
    }
}


