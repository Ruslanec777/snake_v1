using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Infrastructure.GeometricInterfaces;
using snake_v1.Models.BaseItems;
using snake_v1.Models.GeometricPrimitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static snake_v1.Models.Direction;

namespace snake_v1.Models
{
    public class Snake : RigidBody
    {
        private char _headSymol = '0';
        private char _tailSymbol = '*';

        public MoveDirection Direction { get; set; }

        public override List<IPoint> Points { get; set; }

        public RigidBody Tail
        {
            get
            {
                RigidBody TailRigidBody = new(0, 0);

                IPoint[] points = new IPoint[Points.Count - 2];

                Points.RemoveAt(0);
                Points.RemoveRange( Points.Count - 1 ,1);
                Points.CopyTo(0, points, 0, Points.Count );

                TailRigidBody.Figur.Points.Clear();
                TailRigidBody.Figur.Points.AddRange(points);

                return TailRigidBody;
            }
        }

        public bool IsHitTail()
        {

            foreach (var item in Points.Where(x=>x!=Head && x!=Points.Last()))
            {
                if (item.IsHit(Head))
                {
                    return true;
                }
            }
            return false;
        }

        public IPoint Head
        {
            get
            {
                return Points[0];
            }
        }

        public Snake(int x, int y, int length, MoveDirection direction, ConsoleColor color) : base(x, y, new SnakeFigur(color))
        {
            Direction = direction;

            Color = color;

            Points = base.Points;
            //Init(length);
        }


        //public void Init(int length)
        //{
        //    Points.Add(new Point(0, 0, _headSymol, Color));

        //    for (int i = 0; i < length; i++)
        //    {
        //        IPoint point = (IPoint)Points.Last().Clone();
        //        point.Symbol = _tailSymbol;
        //        point.MoveBack(Direction, 1);

        //        Points.Add(point);
        //    }

        //    /*  Snake.Add(new Point(30, 30, '0'));
        //      Snake[0].CurrentDirectionPoint = currentDirection;


        //      for (int i = 1; i < 6; i++)
        //      {
        //          if (i==5)
        //          {
        //              SnakeAddItemSpace(Snake[Snake.Count - 1]);
        //              Snake[i].CurrentDirectionPoint = currentDirection;
        //              break;
        //          }
        //          SnakeAddItemBody(Snake[Snake.Count - 1]);
        //          Snake[i].CurrentDirectionPoint = currentDirection;
        //      }*/
        //}

        public void SnakeAddItem()
        {
            Points.RemoveAt(Points.Count - 1);
            //TODO
            SnakeAddItemBody(Points[Points.Count - 1]);

            SnakeAddItemSpace(Points[Points.Count - 1]);

        }
        /// <summary>
        /// Добавляем элемени в змейку с учетом движения хвоста
        /// </summary>
        /// <param name="point">элемент к которому цепляется новое звено</param>
        private void SnakeAddItemBody(IPoint point)
        {
            switch (Direction)
            {
                case MoveDirection.Up:
                    Points.Add(new Point(Points[Points.Count - 1].X, Points[Points.Count - 1].Y - 1, _tailSymbol));
                    break;
                case MoveDirection.Right:
                    Points.Add(new Point(Points[Points.Count - 1].X - 1, Points[Points.Count - 1].Y, _tailSymbol));
                    break;
                case MoveDirection.Down:
                    Points.Add(new Point(Points[Points.Count - 1].X, Points[Points.Count - 1].Y + 1, _tailSymbol));
                    break;
                case MoveDirection.Left:
                    Points.Add(new Point(Points[Points.Count - 1].X + 1, Points[Points.Count - 1].Y, _tailSymbol));
                    break;
                default:
                    break;
            }
        }

        private void SnakeAddItemSpace(IPoint point)
        {
            //TODO LastDirection
            switch (point.LastMove)
            {
                case MoveDirection.Up:
                    Points.Add(new Point(Points[Points.Count - 1].X, Points[Points.Count - 1].Y - 1, ' '));
                    break;
                case MoveDirection.Right:
                    Points.Add(new Point(Points[Points.Count - 1].X - 1, Points[Points.Count - 1].Y, ' '));
                    break;
                case MoveDirection.Down:
                    Points.Add(new Point(Points[Points.Count - 1].X, Points[Points.Count - 1].Y + 1, ' '));
                    break;
                case MoveDirection.Left:
                    Points.Add(new Point(Points[Points.Count - 1].X + 1, Points[Points.Count - 1].Y, ' '));
                    break;
                default:
                    break;
            }
        }

        public void Move()
        {
            SnakeMovesNextStep();
            //PaintSnake();
        }

        private void PaintSnake()
        {
            foreach (Point item in Points)
            {
                // item.Drow();
            }
        }

        private void SnakeMovesNextStep()
        {
            IPoint pointForNextStep = null;
            IPoint tempPoint;

            for (int i = 0; i < Points.Count; i++)
            {
                //есть ли способ скопировать объект?
                //сохраняем точку для перемещения следующему звену

                if (i == 0)
                {
                    pointForNextStep = new Point(Points[i].X, Points[i].Y, Points[i].Symbol, Color);
                    Points[i].Move(Direction, 1);
                    continue;
                }

                // перемещаем элемент на место предыдущего 
                char currentSymbol = Points[i].Symbol;

                tempPoint = Points[i];

                MoveDirection tempDirection = DetermineMovementPoint(Points[i], pointForNextStep);

                Points[i] = pointForNextStep;
                Points[i].Symbol = tempPoint.Symbol;
                Points[i].LastMove = tempDirection;

                pointForNextStep = tempPoint;

                // определяем посдеднее направление перемещения элемента
            }
        }

        private MoveDirection DetermineMovementPoint(IPoint point, IPoint nextPoint)
        {
            MoveDirection directionPoint = default;

            if (nextPoint.X > point.X)
            {
                directionPoint = MoveDirection.Right;
            }
            else if (nextPoint.X < point.X)
            {
                directionPoint = MoveDirection.Left;
            }
            else if (nextPoint.Y > point.Y)
            {
                directionPoint = MoveDirection.Up;
            }
            else if (nextPoint.Y < point.Y)
            {
                directionPoint = MoveDirection.Down;
            }

            return directionPoint;
        }

        public override void Move(MoveDirection moveDirection, int count)
        {
            switch (Direction)
            {
                case MoveDirection.Up:
                    StartPoint.Y -= 1;
                    break;
                case MoveDirection.Right:
                    StartPoint.X += 1;

                    break;
                case MoveDirection.Down:
                    StartPoint.Y += 1;

                    break;
                case MoveDirection.Left:
                    StartPoint.X -= 1;

                    break;
                default:
                    break;
            }

            //Figur.TransformMotionSimulation(Direction);

            //DeleteTail();
            //AddHead();
            ////_head.Draw();
            // this.Draw();
        }

        private void DeleteTail()
        {
            //_points.Remove(_tail);
            //_tail.Delete();
            //_tail = _points[0];
        }

        private void AddHead()
        {

            //_head = (IPoint)_points.Last().Clone();
            //ReplacingOldHeadSymbol();
            //_head.Move(Direction, 1);
            //_points.Add(_head);

        }

        private void ReplacingOldHeadSymbol()
        {
            //_points.Last().Symbol = _tail.Symbol;
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
                    if (Direction != MoveDirection.Right && Direction != MoveDirection.Left)
                    {
                        Direction = MoveDirection.Left;
                        //Figur.TransformMotionSimulation(Direction);
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (Direction != MoveDirection.Left && Direction != MoveDirection.Right)
                    {
                        Direction = MoveDirection.Right;
                        //Figur.TransformMotionSimulation(Direction);
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Direction != MoveDirection.Up && Direction != MoveDirection.Down)
                    {
                        Direction = MoveDirection.Down;
                        //Figur.TransformMotionSimulation(Direction);
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (Direction != MoveDirection.Down && Direction != MoveDirection.Up)
                    {
                        Direction = MoveDirection.Up;
                        //Figur.TransformMotionSimulation(Direction);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
