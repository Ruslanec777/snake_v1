using snake_v1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public interface IPoint : IDrawble, IDeleteble, IMovable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; }
        public char Symbol { get; }

    }
}
