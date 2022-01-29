using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public interface IStartPoint
    {
        IPoint StartPoint { get; set; }
    }
}
