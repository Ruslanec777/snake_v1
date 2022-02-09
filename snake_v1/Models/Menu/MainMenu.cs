using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.Menu
{
    public class MainMenu:Menu
    {

        public override void Init()
        {
            MenuItems.Add(new MenuItem("Header", 95, 2, ConsoleColor.Red, "Змейка"));
            MenuItems.Add(new MenuItem("Header", 95, 2, ConsoleColor.Red, "Змейка"));
             Console.ReadKey();
        }

        public void AddScore()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void ResetScore()
        {
            throw new NotImplementedException();
        }

        public void WriteGameOver()
        {
            throw new NotImplementedException();
        }
    }
}
