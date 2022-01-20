using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{

    /// <summary>
    /// Умеет рисовать объект и удалять ,принимает цвет
    /// </summary>
    public abstract class GameObject<T> where T : IPoint, IRigidPoint
    {
        public List<T> Points;
        protected ConsoleColor _color;

        public GameObject(ConsoleColor color)
        {
            Points = new List<T>();
            _color = color;
        }

        public void Draw()
        {
            Console.ForegroundColor = _color;

            foreach (var point in Points)
            {
                point.Draw();
            }

            Console.ResetColor();

        }

        public void Delete()
        {
            foreach (var point in Points)
            {
                point.Delete();
            }

        }

        //public bool IsHit(IPoint point)
        //{

        //    return _points.Any(x => x.IsHit(point));
        //}

        //public bool IsHit(IRigidBody gameObject)
        //{
        //    return _points.Any(x => gameObject.IsHit(x));
        //    // расписать forEach
        //}
    }
}
