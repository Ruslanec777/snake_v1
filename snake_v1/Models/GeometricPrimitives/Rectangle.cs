using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;


namespace snake_v1.Models.GeometricPrimitives
{
    class Rectangle : GeometricPrimitiv ,IRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<IPoint> Points { get; }

        public ConsoleColor Color { get; set; } = ConsoleColor.Red;

        public Rectangle(int width, int height)
        {
            Height = height;
            Width = width;

            InitPoints( width , height);
        }

        public Rectangle(int height, int width, ConsoleColor color)
           : this(height, width)
        {
            Color = color;
        }

        //public int Hight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void InitPoints(int height, int width)
        {
            int x = 0;
            int y = 0;

            var upWall = new Line( width, LineType.Horizontal, Color);
            
            var rightWall = new Line( height, LineType.Vertical, Color);
            rightWall.OffSet = new Vector2D(width, 1);

            var downWall = new Line(width, LineType.Horizontal, Color);
            downWall.OffSet = new Vector2D(width, 1);

            var leftWall = new Line( height, LineType.Vertical, Color);
            leftWall.OffSet = new Vector2D(0, 1);

            var anglRightDown = new Angl( AngleType.RightDown, Color);
            
            var anglLeftDown = new Angl( AngleType.LeftDown, Color);
            anglLeftDown.OffSet = new Vector2D(width, 0);

            var anglLeftUp = new Angl( AngleType.LeftUp, Color);
            anglLeftUp.OffSet = new Vector2D(width, height);

            var anglRightUp = new Angl( AngleType.RightUp, Color);
            anglRightUp.OffSet = new Vector2D(0, height);

            //var mapElements = new List<GameObject>() {anglRightDown, anglLeftDown, anglLeftUp, anglRightUp };
            var mapElements = new List<GeometricPrimitiv>() { upWall, downWall, leftWall, rightWall, anglRightDown, anglLeftDown, anglLeftUp, anglRightUp };

            foreach (var geometricFigure in mapElements)
            {
                Points.AddRange(geometricFigure.Points);
            }
        }
    }
}
