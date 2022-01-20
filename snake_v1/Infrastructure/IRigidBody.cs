using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    interface IRigidBody
    {
        bool IsHit(RigidBody rigidBody);
        bool IsHit(RigidPoint point);
        //bool IsHit(RigidObject point);
    }
}
