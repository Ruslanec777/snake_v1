using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using System;

namespace snake_v1.Models.GeometricPrimitives
{
    class Angl : GeometricPrimitiv
    {
        private readonly char _anglleftUp = (char)9565;
        private readonly char _anglLeftDown = (char)9559;
        private readonly char _anglRightUp = (char)9562;
        private readonly char _anglRightDown = (char)9556;

        public AngleType TypeOfAngle { get; set; }

        //public ConsoleColor Color { get ; set; }
        //public char CharOfPicture { get; set; }

        public Angl(AngleType angleType, ConsoleColor color)
        {
            Color = color;
            TypeOfAngle = angleType;
            InitPoints(angleType);
        }

        private void InitPoints(AngleType angleType)
        {
            Point point = new Point(Color);
            switch (angleType)
            {
                case AngleType.LeftUp:
                    point.Symbol = _anglleftUp;
                    break;

                case AngleType.LeftDown:
                    point.Symbol = _anglLeftDown;
                    break;

                case AngleType.RightUp:
                    point.Symbol = _anglRightUp;
                    break;

                case AngleType.RightDown:
                    point.Symbol = _anglRightDown;
                    break;

                default:
                    break;
            }

            Points.Add(point);
        }
    }
}
