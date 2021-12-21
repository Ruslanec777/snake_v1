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

        static MainSnake()
        {
            Snake.Add(new Point(30, 30, '*'));
        }

        public static void SnakeAdditem()
        {
            //делать тут
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
                    HistoryPoint = new Point(Snake[i].X, Snake[i].Y, Snake[i].Symbol);
                    Snake[i].Move(currentDirection, 1);
                    continue;
                }

                tempPoint = new Point(Snake[i].X, Snake[i].Y, Snake[i].Symbol);

                Snake[i] = HistoryPoint;

                HistoryPoint = tempPoint;
            }
        }
    }
}
