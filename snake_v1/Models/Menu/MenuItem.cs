using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using snake_v1.Models.GeometricPrimitives;
using System;

namespace snake_v1.Models.Menu
{
    //TODO как организовать наследование что бы создавать переменную типа интерфейса ?
    class MenuItem : Picture, IMenuItem
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                Console.SetCursorPosition(StartPoint.X + Width / 2 - _text.Length / 2, StartPoint.Y + Height / 2);
                Console.Write(Text);
            }
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public Vector2D BottomLeftEdge
        {
            get
            {
                return new Vector2D(StartPoint.X, StartPoint.Y + Height);
            }
        }

        public Vector2D BottomRightEdge
        {
            get
            {
                return new Vector2D(StartPoint.X+Width, StartPoint.Y + Height);
            }
        }

        public MenuItem(int WidthPercentage ,int TopMargin, ConsoleColor color, string text) 
                 : base((Console.WindowWidth- (Console.WindowWidth/100)*WidthPercentage)/2, TopMargin, new Rectangle((Console.WindowWidth / 100) * WidthPercentage, 3), color)
        {
            //StartPoint.X = x;
            //StartPoint.Y = y;
            Width = (Console.WindowWidth / 100) * WidthPercentage;
            Height = 3;
            //Figur = new Rectangle(width, height, color);
            Text = text;
        }

        //public void Delete()
        //{
        //    Console.SetCursorPosition(X, Y);

        //    //Text.Lengt
        //    for (int i = 0; i < Text.Length; i++)
        //    {
        //        Console.Write(' ');
        //    }

        //}

        //public void Draw()
        //{
        //    Console.SetCursorPosition(X, Y);
        //    Console.WriteLine($"{Text}");
        //}

    }
}
