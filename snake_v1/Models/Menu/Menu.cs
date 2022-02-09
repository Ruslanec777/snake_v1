using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.Menu
{
    public abstract class Menu : IMenu
    {
        public IList<IMenuItem> MenuItems { get ; set ; }

        public void Draw()
        {
            foreach (var menuItem in MenuItems)
            {
                menuItem.Draw();
            }           
        }

        public abstract void Init();
    }
}
