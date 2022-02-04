using snake_v1.Infrastructure.GeometricInterfaces;
using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public interface IRigidBody:IGameObject
    {
        // public List<IRigidPoint> Points { get; }

        public bool IsHit(IRigidBody rigidBody);

        public bool IsHit(IPoint point);

        //public bool IsHit(IRigidPoint rigidPoint);
    }
}
