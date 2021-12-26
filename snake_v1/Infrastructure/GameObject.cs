using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    abstract class GameObject
    {
        protected List<IPoint> _points;
        protected ConsoleColor _color;

        public GameObject(ConsoleColor color)
        {
            _points = new List<IPoint>();
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
    }
}
