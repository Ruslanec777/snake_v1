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

                switch (AlignText)
                {
                    case Align.Centre:
                        Console.SetCursorPosition(StartPoint.X + Width / 2 - _text.Length / 2, StartPoint.Y + Height / 2);
                        break;

                    case Align.left:
                        Console.SetCursorPosition(StartPoint.X + 2, StartPoint.Y + Height / 2);
                        break;

                    default:
                        break;
                }
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
                return new Vector2D(StartPoint.X + Width, StartPoint.Y + Height);
            }
        }

        public string Name { get; set; }
        public Align AlignText { get; set; }

        public MenuItem(string name, int WidthPercentage, int TopMargin, ConsoleColor color, string text)
                 : base((Console.WindowWidth - ((Console.WindowWidth * WidthPercentage) / 100)) / 2, TopMargin, new Rectangle(Console.WindowWidth * WidthPercentage / 100, 3), color)
        {
            //StartPoint.X = x;
            //StartPoint.Y = y;
            Width = Console.WindowWidth * WidthPercentage / 100;
            Height = 3;
            //Figur = new Rectangle(width, height, color);
            Text = text;
            Name = name;
        }

        public MenuItem(string name, int WidthPercentage, int TopMargin, IMenuItem menuItem, ConsoleColor color, string text, Align alignText)
         : base((Console.WindowWidth - ((Console.WindowWidth * WidthPercentage) / 100)) / 2, TopMargin + menuItem.BottomLeftEdge.Y, new Rectangle(Console.WindowWidth * WidthPercentage / 100, 3), color)
        {
            Width = Console.WindowWidth * WidthPercentage / 100;
            Height = 3;
            Text = text;
            Name = name;
            AlignText = alignText;
        }
    }
}
