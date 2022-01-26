using snake_v1.Enums;
using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.Menu
{
    class MenuItem : IMenuItem
    {
        public string Text { get ; set; }
        public int X { get; set ; }
        public int Y { get; set; }

        public ConsoleColor Color => throw new NotImplementedException();

        public char Symbol => throw new NotImplementedException();

        public void Delete()
        {
            Console.SetCursorPosition(X, Y);
            
            //Text.Lengt
            for (int i = 0; i < Text.Length; i++)
            {
                Console.Write(' ');
            }
                
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine($"{Text}");
        }

        public void Move(MoveDirection direction, int count)
        {
            throw new NotImplementedException();
        }
    }
}
