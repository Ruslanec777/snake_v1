using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure.GeometricInterfaces
{
    public interface IGameObject :IDeleteble,IMovable ,IDrawble
    {
        public IGeometricPrimitive Figur { get; set; } 

        public IPoint StartPoint { get; set; }

        public ConsoleColor Color{ get; set; }

    }
}
