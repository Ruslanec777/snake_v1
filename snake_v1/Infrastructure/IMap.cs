using snake_v1.Models.GeometricFigurs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    interface IMap :  IRigidBody 
    {
        public int Height { get; }

        public int Width { get; }

        public string Name { get; }

        public ConsoleColor ConsoleColor { get; }

        /// <summary>
        /// соприкосновение с картой 
        /// </summary>

    }
}
