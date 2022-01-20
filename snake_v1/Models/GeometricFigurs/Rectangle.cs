using snake_v1.Enums;
using System;
using System.Collections.Generic;


namespace snake_v1.Models.GeometricFigurs
{
    class Rectangle : GeometricFigure
    {
        public Rectangle(int x, int y, int height, int width)
                   : base(x, y)
        {
            Height = height;
            Width = width;
            X = x;
            Y = y;
            InitPoints(x, y, height, width);
        }

        public Rectangle(int x, int y, int height, int width ,ConsoleColor color)
           : this(x, y ,height,width)
        {
            Color = color;
        }


        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        private void InitPoints(int x, int y, int height, int width)
        {
            var upWall = new Line(X + 1, Y, width, LineType.Horizontal, ConsoleColor.Red);
            var rightWall = new Line(X + width, Y + 1, height, LineType.Vertical, ConsoleColor.Red);
            var downWall = new Line(X, Y + height, width, LineType.Horizontal, ConsoleColor.Red);
            var leftWall = new Line(X, Y + 1, height, LineType.Vertical, ConsoleColor.Red);

            var anglRightDown = new Angl(X, Y, AngleType.RightDown, ConsoleColor.Red);
            var anglLeftDown = new Angl(X + width, Y, AngleType.LeftDown, ConsoleColor.Red);
            var anglLeftUp = new Angl(X + width, Y + height, AngleType.LeftUp, ConsoleColor.Red);
            var anglRightUp = new Angl(X, Y + height, AngleType.RightUp, ConsoleColor.Red);

            //var mapElements = new List<GameObject>() {anglRightDown, anglLeftDown, anglLeftUp, anglRightUp };
            var mapElements = new List<GeometricFigure>() { upWall, downWall, leftWall, rightWall, anglRightDown, anglLeftDown, anglLeftUp, anglRightUp };

            foreach (var geometricFigure in mapElements)
            {
                Points.AddRange(geometricFigure.Points);
            }
        }





    }
}
