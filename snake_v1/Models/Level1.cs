using snake_v1.Infrastructure;
using snake_v1.Models.GameItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models
{
    class Level1
    {
        public static void initLevel(List<GameObject> map ,byte windowHeight ,byte windowWidth)
        {
            map.Add(new Wall(ConsoleColor.Red, new Point(0, 0), Enums.MoveDirection.Right, 200));
            map.Add(new Wall(ConsoleColor.Red, new Point(0, 49), Enums.MoveDirection.Right, 200));
            map.Add(new Wall(ConsoleColor.Red, new Point(0, 0), Enums.MoveDirection.Down, 49));
            map.Add(new Wall(ConsoleColor.Red, new Point(49, 0), Enums.MoveDirection.Down, 49));

            foreach (var gameObject in map)
            {
                gameObject.Draw();
            }
        }
    }
}
