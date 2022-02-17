using snake_v1.Models;
using System.Collections.Generic;

namespace snake_v1.Infrastructure
{
    interface IMenu : IDrawble
    {
        IList<IMenuItem> MenuItems { get; set; }

        public Game Game { get; set; }

        void Init();
    }
}
