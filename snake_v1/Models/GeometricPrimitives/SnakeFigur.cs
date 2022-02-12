using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Infrastructure.GeometricInterfaces;
using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.GeometricPrimitives
{
    internal class SnakeFigur : GeometricPrimitiv, ISnakeFigur
    {
        private static char _headSymol = '0';
        private static char _bodySymbol = '*';
        private static char _tailSymbol = ' ';
        private static int _snakeLength = 6;


        public int SnakeLength { get; set; } = _snakeLength;
        public SnakeFigur()
        {

            Points.Add(new Point(0, 0, _headSymol));

            for (int i = 1; i < SnakeLength; i++)
            {
                Points.Add(new Point(i, 0, _bodySymbol));

                if (i == SnakeLength - 1)
                {
                    Points.Last().Symbol = _tailSymbol;
                }
            }
        }

        public SnakeFigur(ConsoleColor color) : this()
        {
            Color = color;
        }

        public SnakeFigur(ConsoleColor color, char headSymol, char bodySymbol, char tailSymbol) : this(color)
        {
            _headSymol = headSymol;
            _bodySymbol = bodySymbol;
            _tailSymbol = tailSymbol;
        }



        public  void TransformMotionSimulation(MoveDirection direction)
        {
            //TODO раскоментировать, заглушил
            Point pointForNextStep = null;
            Point tempPoint;

            for (int i = 0; i < Points.Count; i++)
            {
                //есть ли способ скопировать объект?
                //сохраняем точку для перемещения следующему звену

                if (i == 0)
                {
                    pointForNextStep = (Point)Points[i].Clone();
                    Points[i].Move(direction, 1);
                    continue;
                }

                // перемещаем элемент на место предыдущего 
                char currentSymbol = Points[i].Symbol;

                tempPoint = (Point)Points[i];

                Points[i] = pointForNextStep;
                Points[i].Symbol = tempPoint.Symbol;

                pointForNextStep = tempPoint;

                // определяем посдеднее направление перемещения элемента
                if (pointForNextStep.X > Points[i].X)
                {
                    Points[i].LastMove = MoveDirection.Left;
                }
                else if (pointForNextStep.X < Points[i].X)
                {
                    Points[i].LastMove = MoveDirection.Right;
                }
                else if (pointForNextStep.Y > Points[i].Y)
                {
                    Points[i].LastMove = MoveDirection.Down;
                }
                else if (pointForNextStep.Y < Points[i].Y)
                {
                    Points[i].LastMove = MoveDirection.Up;
                }
            }

            foreach (var point in Points)
            {
                point.MoveBack(direction, 1);
            }
        }


    }
}
