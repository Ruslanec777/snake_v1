using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    interface IMap : IDrawble
    {
        public int Height { get; }

        public int Width { get; }

        public string Name { get; }

        public List<GameObject> Walls { get; }
        /// <summary>
        /// соприкосновение с картой 
        /// </summary>
        public bool IsHit(IGameObject gameObject);

    }
}
