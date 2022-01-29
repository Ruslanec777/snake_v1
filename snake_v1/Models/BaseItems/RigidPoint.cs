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
        /*
         
         namespace generic_class_interface.mods
{
    internal class Counter
    {

        public int Seconds { get; set; }

        public Counter(int x)
        {
            Seconds = x;
        }

        public static explicit operator Counter(int x)
        {
            return new Counter(x) ;
        }
        public static explicit operator int(Counter counter)
        {
            return counter.Seconds;
        }
    }
}
         */
        //public static explicit operator RigidPoint(Point point) => new RigidPoint(point);

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
