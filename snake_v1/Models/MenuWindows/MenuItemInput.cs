using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using System;

namespace snake_v1.Models.MenuWindows
{
    internal class MenuItemInput : MenuItem
    {

        public MenuItemInput(string name, Vector2D startPoint, Vector2D widthHeight, ConsoleColor color, string text, ref string returnedValue, Align alignText = Align.Centre)
                      : base(name, startPoint, widthHeight, color, text, alignText)
        {
            returnedValue = GetInputed();
        }

        public string GetInputed()
        {
            Draw();

            Console.SetCursorPosition(PointOfInput.X, PointOfInput.Y);

            return Console.ReadLine().ToString();
        }
    }
}
