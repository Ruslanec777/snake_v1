using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    internal interface IRectangle
    {
        public int Width { get; set; }

        public int Height { get; set; }
    }
}
