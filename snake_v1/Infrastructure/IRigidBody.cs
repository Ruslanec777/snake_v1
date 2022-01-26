using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    //не наследовать 
    public interface IRigidBody 
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<IRigidPoint> Points { get; }

        public bool IsHit(IRigidBody rigidBody);
    }
}
