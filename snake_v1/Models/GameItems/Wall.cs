using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.GameItems
{
    class Wall : GameObject
    {
        private char _symbolWall;

        private Point _point;

        
        public Wall(ConsoleColor color, Point startPoint, MoveDirection direction, int length)
              : base(color)
        {
            
            if (direction == MoveDirection.Down || direction == MoveDirection.Up)
            {
                //вертикальная полоска
                _symbolWall = (char)9553;
                //_symbolWall = '|';
                Console.WriteLine($"{_symbolWall}");

            }
            else if (direction == MoveDirection.Left || direction == MoveDirection.Right)
            {
                //_symbolWall = '_';
                //горизонтальная полоска
                _symbolWall = (char)9552;
            }

            _point = (Point)startPoint.Clone();
            _point.Color = color;
            _point.Symbol = _symbolWall;

            for (int i = 0; i < length; i++)
            {
                _points.Add(_point);
                _point = (Point)_point.Clone();
                _point.Move(direction, 1);
            }

        }

    }
}
