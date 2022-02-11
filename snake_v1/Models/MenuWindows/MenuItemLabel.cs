using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using snake_v1.Models.GeometricPrimitives;
using System;

namespace snake_v1.Models.MenuWindows
{
    //TODO как организовать наследование что бы создавать переменную типа интерфейса ?
    class MenuItemLabel : Picture, IMenuItem 
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                ClearText();
                _text = value;

                switch (AlignText)
                {
                    case Align.Centre:
                        OffsetText = new Vector2D(StartPoint.X + Width / 2 - _text.Length / 2, StartPoint.Y + Height / 2);

                        Console.SetCursorPosition(OffsetText.X, OffsetText.Y);

                        OffsetInptText = new Vector2D(StartPoint.X + Width / 2 + _text.Length / 2 + 2, StartPoint.Y + Height / 2);
                        break;

                    case Align.left:
                        OffsetText = new Vector2D(StartPoint.X + 2, StartPoint.Y + Height / 2);

                        Console.SetCursorPosition(OffsetText.X, OffsetText.Y);

                        OffsetInptText = new Vector2D(StartPoint.X + 4 + Text.Length, StartPoint.Y + Height / 2);
                        break;

                    default:
                        break;
                }
                Console.Write(Text);
            }
        }

        protected Vector2D OffsetInptText { get; set; }
        protected Vector2D OffsetText { get; set; }

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

        public MenuItemLabel(string name, int WidthPercentage, int TopMargin, ConsoleColor color, string text)
                 : base((Console.WindowWidth - Console.WindowWidth * WidthPercentage / 100) / 2, TopMargin, new Rectangle(Console.WindowWidth * WidthPercentage / 100, 3), color)
        {
            //StartPoint.X = x;
            //StartPoint.Y = y;
            Width = Console.WindowWidth * WidthPercentage / 100;
            Height = 3;
            //Figur = new Rectangle(width, height, color);
            Text = text;
            Name = name;
        }

        public MenuItemLabel(string name, int WidthPercentage, int TopMargin, IMenuItem menuItem, ConsoleColor color, string text, Align alignText = Align.Centre)
         : base((Console.WindowWidth - Console.WindowWidth * WidthPercentage / 100) / 2, TopMargin + menuItem.BottomLeftEdge.Y, new Rectangle(Console.WindowWidth * WidthPercentage / 100, 3), color)
        {
            Width = Console.WindowWidth * WidthPercentage / 100;
            Height = 3;
            AlignText = alignText;
            Text = text;
            Name = name;
        }

        public MenuItemLabel(string name, Vector2D startPoint, Vector2D widthHeight, ConsoleColor color, string text, Align alignText = Align.Centre)
                 : base(startPoint, widthHeight, color)
        {
            Width = widthHeight.X;
            Height = widthHeight.Y;

            AlignText = alignText;
            Text = text;
            Name = name;
        }

        protected void ClearText()
        {
            if (Text != null && OffsetText!=null)
            {
                Console.SetCursorPosition(OffsetText.X, OffsetText.Y);
                for (int i = 0; i < Text.Length; i++)
                {
                    Console.Write(" ");
                }
            }
        }

        public override void Draw()
        {
            if (Figur.Points.Count == 0)
            {
                return;
            }
            ConsoleColor tempConsoleColor = Console.ForegroundColor;

            Console.ForegroundColor = Color;
            // TODO меняется ли сам Figur?
            //foreach (var point in Points)
            //{
            //    point.X += StartPoint.X;
            //    point.Y += StartPoint.Y;
            //    point.Draw();
            //}

            foreach (var point in Points)
            {
                point.Color = Color;
                point.Draw();
            }

            Console.ResetColor();
            Console.ForegroundColor = tempConsoleColor;
        }


    }
}
