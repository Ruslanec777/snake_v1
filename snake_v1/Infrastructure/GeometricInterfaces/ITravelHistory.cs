using snake_v1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure.GeometricInterfaces
{
    public interface ITravelHistory
    {
        public MoveDirection LastMove { get; set; }
    }
}
