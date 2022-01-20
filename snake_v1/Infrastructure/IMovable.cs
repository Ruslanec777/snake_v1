using snake_v1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public interface IMovable
    {
        void Move(MoveDirection direction, int count);
    }
}
