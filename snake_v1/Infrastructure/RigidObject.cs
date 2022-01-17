using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    class RigidObject : IRigidBody
    {
        protected List<IRigidPoint> _points;
        protected ConsoleColor _color;

        public RigidObject(ConsoleColor color)
        {
            _points = new List<IRigidPoint>();
            _color = color;
        }

        public void Draw()
        {
            Console.ForegroundColor = _color;

            foreach (var point in _points)
            {
                point.Draw();
            }

            Console.ResetColor();

        }

        public void Delete()
        {
            foreach (var point in _points)
            {
                point.Delete();
            }

        }

        public bool IsHit(IPoint point)
        {
            throw new NotImplementedException();
        }

        public bool IsHit(GameObject point)
        {
            throw new NotImplementedException();
        }

        public bool IsHit(IRigidPoint point)
        {

            return _points.Any(x => x.IsHit(point));
        }

        public bool IsHit(IRigidBody gameObject)
        {
            return _points.Any(x => gameObject.IsHit(x));
            // расписать forEach
        }
    }
}
