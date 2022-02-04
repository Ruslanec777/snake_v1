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
        //public List<IPoint> Points { get; set; } = new List<IPoint>();
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;

            InitPoints( width , height);
        }

        public Rectangle(int width, int height,  ConsoleColor color)
           : this( width ,height)
        {
            Color = color;
        }

        //public int Hight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void InitPoints(int width, int height)
        {
            //int x = 0;
            //int y = 0;

            var upWall = new Line( width, LineType.Horizontal, Color);
            //upWall.OffSet = new Vector2D(0, 1);
            
            var rightWall = new Line( height, LineType.Vertical, Color);
            rightWall.OffSet = new Vector2D(width, 0);

            var downWall = new Line(width, LineType.Horizontal, Color);
            downWall.OffSet = new Vector2D(0, height);

            var leftWall = new Line( height, LineType.Vertical, Color);
           

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
                TakeOnFigure(geometricFigure);
            }
        }

        public override void TransformMotionSimulation(MoveDirection direction)
        {
            throw new NotImplementedException();
        }
    }
}
