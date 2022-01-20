using snake_v1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public interface IPoint : ICloneable, IDrawble, IDeleteble , IMovable
    {
        public int X { get; }
        public int Y { get; }
        ConsoleColor Color { get; set; }
        char Symbol { get; set; }

    }
}
