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

            /*  Snake.Add(new Point(30, 30, '0'));
              Snake[0].CurrentDirectionPoint = currentDirection;


              for (int i = 1; i < 6; i++)
              {
                  if (i==5)
                  {
                      SnakeAddItemSpace(Snake[Snake.Count - 1]);
                      Snake[i].CurrentDirectionPoint = currentDirection;
                      break;
                  }
                  SnakeAddItemBody(Snake[Snake.Count - 1]);
                  Snake[i].CurrentDirectionPoint = currentDirection;
              }*/
        }

        //public static void SnakeAddItem()
        //{
        //    Snake.RemoveAt(Snake.Count - 1);

        //    SnakeAddItemBody(Snake[ Snake.Count - 1]);

        //    SnakeAddItemSpace(Snake[ Snake.Count - 1]);

        //}
        /// <summary>
        /// Добавляем элемени в змейку с учетом движения хвоста
        /// </summary>
        /// <param name="point">элемент к которому цепляется новое звено</param>
        //private static void SnakeAddItemBody(Point point)
        //{
        //    switch (point.CurrentDirectionPoint)
        //    {
        //        case MoveDirection.Up:
        //            Snake.Add(new Point(Snake[Snake.Count - 1].X, Snake[Snake.Count - 1].Y - 1, snakeBody));
        //            break;
        //        case MoveDirection.Right:
        //            Snake.Add(new Point(Snake[Snake.Count - 1].X - 1, Snake[Snake.Count - 1].Y, snakeBody));
        //            break;
        //        case MoveDirection.Down:
        //            Snake.Add(new Point(Snake[Snake.Count - 1].X, Snake[Snake.Count - 1].Y + 1, snakeBody));
        //            break;
        //        case MoveDirection.Left:
        //            Snake.Add(new Point(Snake[Snake.Count - 1].X + 1, Snake[Snake.Count - 1].Y, snakeBody));
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private static void SnakeAddItemSpace(Point point)
        //{
        //    switch (point.CurrentDirectionPoint)
        //    {
        //        case MoveDirection.Up:
        //            Snake.Add(new Point(Snake[Snake.Count - 1].X, Snake[Snake.Count - 1].Y - 1, ' '));
        //            break;
        //        case MoveDirection.Right:
        //            Snake.Add(new Point(Snake[Snake.Count - 1].X - 1, Snake[Snake.Count - 1].Y, ' '));
        //            break;
        //        case MoveDirection.Down:
        //            Snake.Add(new Point(Snake[Snake.Count - 1].X, Snake[Snake.Count - 1].Y + 1, ' '));
        //            break;
        //        case MoveDirection.Left:
        //            Snake.Add(new Point(Snake[Snake.Count - 1].X + 1, Snake[Snake.Count - 1].Y, ' '));
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public static void SnakeMove()
        //{
        //    SnakeMovesNextStep();
        //    PaintSnake();
        //}

        //private static void PaintSnake()
        //{
        //    foreach (Point item in Snake)
        //    {
        //        item.Drow();
        //    }
        //}

        //private static void SnakeMovesNextStep()
        //{
        //    Point pointForNextStep = null;
        //    Point tempPoint;

        //    for (int i = 0; i < Snake.Count; i++)
        //    {
        //        //есть ли способ скопировать объект?
        //        //сохраняем точку для перемещения следующему звену

        //        if (i == 0)
        //        {
        //            pointForNextStep = new Point(Snake[i].X, Snake[i].Y, Snake[i].Symbol);
        //            Snake[i].Move(currentDirection, 1);
        //            continue;
        //        }

        //        // перемещаем элемент на место предыдущего 
        //        char currentSymbol = Snake[i].Symbol;

        //        tempPoint = Snake[i];

        //        Snake[i] = pointForNextStep;
        //        Snake[i].Symbol = tempPoint.Symbol;

        //        pointForNextStep = tempPoint;

        //        // определяем посдеднее направление перемещения элемента
        //        if (pointForNextStep.X > Snake[i].X)
        //        {
        //            Snake[i].CurrentDirectionPoint = MoveDirection.Left;
        //        }
        //        else if (pointForNextStep.X < Snake[i].X)
        //        {
        //            Snake[i].CurrentDirectionPoint = MoveDirection.Right;
        //        }
        //        else if (pointForNextStep.Y > Snake[i].Y)
        //        {
        //            Snake[i].CurrentDirectionPoint = MoveDirection.Down;
        //        }
        //        else if (pointForNextStep.Y < Snake[i].Y)
        //        {
        //            Snake[i].CurrentDirectionPoint = MoveDirection.Up;
        //        }
        //    }
        //}

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
