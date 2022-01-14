using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models;
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
   public  class GameObject :GeometricFigure, IGameObject
    {
        protected ConsoleColor _color;

        public GameObject(GeometricFigure geometricFigure)
                   :base (geometricFigure.X, geometricFigure.Y)
        {
            Points = geometricFigure.Points;
        }

        public GameObject(GeometricFigure geometricFigure, ConsoleColor color)
                   : base(geometricFigure.X ,geometricFigure.Y)
        {
            Points = geometricFigure.Points;
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

        public bool IsHit(IPoint point)
        {
            return Points.Any(x => x.IsHit(point));
        }

        public bool IsHit(IGameObject gameObject)
        {
            return Points.Any(x => gameObject.IsHit(x));
            // расписать forEach
        }

        public void Move(MoveDirection direction, int count)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
