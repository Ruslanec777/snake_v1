using snake_v1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    interface IMenu:IDrawble
    {
        IList<IMenuItem> MenuItems { get; set; }

        void Init();

        public RequestType RequestFromMenu { get; set; }
    }
}
