using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.GameItems
{
    public class Line : GameObject
    {
        //private char _symbolWall;

        //private Point _point;


        public Line(int x, int y, int length, char symbol, LineType lineType, ConsoleColor color)
              : base(color)
        {
            InitPoints(x, y, length, symbol, lineType);
        }

        private void InitPoints(int x, int y, int length, char symbol, LineType lineType)
        {
            switch (lineType)
            {
                case LineType.Vertical:
                    for (int i = 0; i < length; i++)
                    {
                        _points.Add(new Point(x, y++, symbol, _color));
                    }
                    break;

                case LineType.Horizontal:
                    for (int i = 0; i < length; i++)
                    {
                        _points.Add(new Point(x++, y, symbol, _color));
                    }
                    break;
            }
        }

    }
}
