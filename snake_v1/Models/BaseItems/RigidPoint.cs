using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.BaseItems
{
    class RigidPoint : Point, IRigidPoint
    {
        private RigidPoint(int x, int y)
                    : base(x, y)
        {
        }

        public RigidPoint(int x, int y, char symbol, ConsoleColor color)
                   : base(x, y, symbol, color)
        {
        }

        public RigidPoint(Point point)
                   : base(point.X, point.Y, point.Symbol, point.Color)
        {

        }

        public bool isHit(RigidPoint rigidPoint)
        {
            return X == rigidPoint.X && Y == rigidPoint.Y;
        }
    }
}
