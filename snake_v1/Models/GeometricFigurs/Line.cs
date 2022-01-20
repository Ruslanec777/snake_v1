using snake_v1.Enums;
using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.GeometricFigurs
{
    public class Line : GeometricFigure
    {
        private readonly char _verticalChar = (char)9553;
        private readonly char _horizontalChar = (char)9552;

        public int Length { get; set; }
        public LineType lineType { get; set; }

        public Line(int x, int y, int length, LineType lineType)
             : base(x, y)
        {
            InitPoints(x, y, length, lineType);
        }

        public Line(int x, int y, int length, LineType lineType, ConsoleColor color)
             : base(x, y)
        {
            Color = color;
            InitPoints(x, y, length, lineType);
        }

        private void InitPoints(int x, int y, int length, LineType lineType)
        {
            switch (lineType)
            {
                case LineType.Vertical:
                    for (int i = 0; i < length; i++)
                    {
                        Points.Add(new Point(x, y++, _verticalChar, Color));
                    }
                    break;

                case LineType.Horizontal:
                    for (int i = 0; i < length; i++)
                    {
                        Points.Add(new Point(x++, y, _horizontalChar, Color));
                    }
                    break;
            }
        }

    }
}
