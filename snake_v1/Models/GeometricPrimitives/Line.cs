using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.GeometricPrimitives
{
    //TODO решить как передавать примитив или преобразовать примитив в картинку
    public class Line : GeometricPrimitiv ,ILine
    {
        private readonly char _verticalChar = (char)9553;
        private readonly char _horizontalChar = (char)9552;

        public int Length { get; set; }
        public LineType TypeLine { get; set; }
        //TODO как унаследовать присвоение new() ?
        //public ConsoleColor Color { get ; set ; }

        public Line( int length, LineType lineType)          
        {
            Length = length;
            TypeLine = lineType;

            InitPoints(length, lineType);
        }

        public Line(int length, LineType lineType, ConsoleColor color)            
        {
            Color = color;
            InitPoints( length, lineType);
        }

        private void InitPoints(int length, LineType lineType)
        {
            int x=0;
            int y=0;

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

        public override void TransformMotionSimulation(MoveDirection direction)
        {
            throw new NotImplementedException();
        }
    }
}
