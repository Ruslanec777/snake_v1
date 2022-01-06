using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static snake_v1.Models.Direction;

namespace snake_v1.Models
{
    class Snake : GameObject
    {
        private IPoint _head;
        private IPoint _tail;

        public static char snakeHead = '0';

        private MoveDirection _direction;

        public Snake(IPoint tail, int length, MoveDirection direction) : base(ConsoleColor.Green)
        {
            _tail = tail;
            _direction = direction;


            Init(length);
        }


        public void Init(int length)
        {
            _points.Add(_tail);

            for (int i = 0; i < length; i++)
            {
                IPoint point = (IPoint)_points.Last().Clone();
                point.Move(_direction, 1);

                _points.Add(point);
            }

            _head = _points.Last();
            _head.Symbol = '0';

        }

        public void Move()
        {
            DeleteTail();
            AddHead();
            //_head.Draw();
            this.Draw();
        }

        private void DeleteTail()
        {
            _points.Remove(_tail);
            _tail.Delete();
            _tail = _points[0];
        }

        private void AddHead()
        {

            _head = (IPoint)_points.Last().Clone();
            ReplacingOldHeadSymbol();
            _head.Move(_direction, 1);
            _points.Add(_head);

        }

        private void ReplacingOldHeadSymbol()
        {
            _points.Last().Symbol = _tail.Symbol;
        }

        private void TouchControl(Point point, MoveDirection direction)
        {
            switch (direction)
            {
                case MoveDirection.Up:

                    break;
                case MoveDirection.Right:
                    break;
                case MoveDirection.Down:
                    break;
                case MoveDirection.Left:
                    break;
                default:
                    break;
            }
        }

        public void ChangeDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (_direction != MoveDirection.Right)
                    {
                        _direction = MoveDirection.Left;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (_direction != MoveDirection.Left)
                    {
                        _direction = MoveDirection.Right;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (_direction != MoveDirection.Up)
                    {
                        _direction = MoveDirection.Down;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (_direction != MoveDirection.Down)
                    {
                        _direction = MoveDirection.Up;
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
