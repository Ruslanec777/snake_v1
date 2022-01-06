using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.GameItems
{
    class Angl : GameObject
    {
        private readonly char _anglleftUp = (char)9565;
        private readonly char _anglLeftDown = (char)9559;
        private readonly char _anglRightUp = (char)9562;
        private readonly char _anglRightDown = (char)9556;

        public Angl(int x, int y, AngleType angleType, ConsoleColor color)
              : base(color)
        {
            InitPoints(x, y, angleType);
        }

        private void InitPoints(int x, int y, AngleType angleType)
        {
            switch (angleType)
            {
                case AngleType.LeftUp:
                    _points.Add(new Point(x, y, _anglleftUp, _color));
                    break;

                case AngleType.LeftDown:
                    _points.Add(new Point(x, y, _anglLeftDown, _color));
                    break;

                case AngleType.RightUp:
                    _points.Add(new Point(x, y, _anglRightUp, _color));
                    break;

                case AngleType.RightDown:
                    _points.Add(new Point(x, y, _anglRightDown, _color));
                    break;

                default:
                    break;
            }
        }
    }
}
