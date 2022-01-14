using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public interface IStartCoordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
