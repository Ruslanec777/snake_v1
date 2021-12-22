using snake_v1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static snake_v1.Models.Direction;

namespace snake_v1.Models
{
    class MainSnake
    {
        public static List<Point> Snake = new List<Point>();
        public static char snakeHead = '0';
        public static char snakeBody = '*';


        public static void MainSnakeInical()
        {
            Snake.Add(new Point(30, 30, '0'));
            Snake[0].CurrentDirectionPoint = currentDirection;

            for (int i = 1; i < 6; i++)
            {
                SnakeAddItem(Snake[Snake.Count - 1]);
                Snake[i].CurrentDirectionPoint = currentDirection;
            }
        }
        /// <summary>
        /// Добавляем элемени в змейку с учетом движения хвоста
        /// </summary>
        /// <param name="point">элемент к которому цепляется новое звено</param>
        public static void SnakeAddItem(Point point)
        {

            switch (point.CurrentDirectionPoint)
            {
                case MoveDirection.Up:
                    Snake.Add(new Point(Snake[Snake.Count - 1].X, Snake[Snake.Count - 1].Y - 1, snakeBody));
                    break;
                case MoveDirection.Right:
                    Snake.Add(new Point(Snake[Snake.Count - 1].X - 1, Snake[Snake.Count - 1].Y, snakeBody));
                    break;
                case MoveDirection.Down:
                    Snake.Add(new Point(Snake[Snake.Count - 1].X, Snake[Snake.Count - 1].Y + 1, snakeBody));
                    break;
                case MoveDirection.Left:
                    Snake.Add(new Point(Snake[Snake.Count - 1].X + 1, Snake[Snake.Count - 1].Y, snakeBody));
                    break;
                default:
                    break;

            }
        }

        public static void SnakeMove()
        {
            SnakeMovesNextStep();
            PaintSnake();
        }

        private static void PaintSnake()
        {
            foreach (Point item in Snake)
            {
                item.Drow();
            }
        }

        private static void SnakeMovesNextStep()
        {
            Point HistoryPoint = null;

            Point tempPoint;

            for (int i = 0; i < Snake.Count; i++)
            {
                //есть ли способ скопировать объект?
                //сохраняем точку для перемещения следующему звену

                if (i == 0)
                {
                    HistoryPoint = new Point(Snake[i].X, Snake[i].Y, MainSnake.snakeHead);
                    Snake[i].Move(currentDirection, 1);
                    continue;
                }

                tempPoint = new Point(Snake[i].X, Snake[i].Y, MainSnake.snakeBody);

                Snake[i] = HistoryPoint;

                if (i == 1)
                {
                    Snake[i].Symbol = MainSnake.snakeBody;
                }

                HistoryPoint = tempPoint;

                if (HistoryPoint.X > Snake[i].X)
                {
                    Snake[i].CurrentDirectionPoint = MoveDirection.Right;
                }
                else if (HistoryPoint.X < Snake[i].X)
                {
                    Snake[i].CurrentDirectionPoint = MoveDirection.Left;
                }
                else if (HistoryPoint.Y > Snake[i].Y)
                {
                    Snake[i].CurrentDirectionPoint = MoveDirection.Up;
                }
                else if (HistoryPoint.Y > Snake[i].Y)
                {
                    Snake[i].CurrentDirectionPoint = MoveDirection.Down;
                }
            }
        }
    }
}
