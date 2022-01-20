using snake_v1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.GeometricFigurs
{
    class Angl : GeometricFigure
    {
        private readonly char _anglleftUp = (char)9565;
        private readonly char _anglLeftDown = (char)9559;
        private readonly char _anglRightUp = (char)9562;
        private readonly char _anglRightDown = (char)9556;

        public AngleType AngleType { get; set; }

        public Angl(int x, int y, AngleType angleType, ConsoleColor color)
              : base(x, y)
        {
            AngleType = angleType;
            InitPoints(x, y, angleType, color);
        }

        private void InitPoints(int x, int y, AngleType angleType, ConsoleColor color)
        {
            switch (angleType)
            {
                case AngleType.LeftUp:
                    Points.Add(new Point(x, y, _anglleftUp, color));
                    break;

                case AngleType.LeftDown:
                    Points.Add(new Point(x, y, _anglLeftDown, color));
                    break;

                case AngleType.RightUp:
                    Points.Add(new Point(x, y, _anglRightUp, color));
                    break;

                case AngleType.RightDown:
                    Points.Add(new Point(x, y, _anglRightDown, color));
                    break;

                default:
                    break;
            }
        }
    }
}
