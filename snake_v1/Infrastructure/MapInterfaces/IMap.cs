using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public interface IMap : IRigidBody, IRectangle, IStartPoint
    {
        string Name { get; }


        /// <summary>
        /// соприкосновение с картой 
        /// </summary>

    }
}
