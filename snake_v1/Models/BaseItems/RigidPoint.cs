using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.BaseItems
{
    public class RigidPoint : Point, IRigidPoint
    {
        public RigidPoint(int x, int y)
                   : base(x, y)
        {
        }

        public RigidPoint(int x, int y, char symbol)
                   : base(x, y, symbol)
        {
        }

        public RigidPoint(int x, int y, char symbol, ConsoleColor color)
                   : base(x, y, symbol, color)
        {
        }

        public RigidPoint(Point point) : this(point.X, point.Y, point.Symbol, point.Color)
        {
            //TODO можно ли из тела конструктора вызвать this или base ? 
        }

        public bool IsHit(IRigidPoint rigidPoint)
        {
            return X==rigidPoint.X && Y==rigidPoint.Y;
        }

    }
}
