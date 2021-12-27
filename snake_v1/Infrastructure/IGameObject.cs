using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    interface IGameObject:IDrawble
    {
        /// <summary>
        /// соприкосновение с точкой 
        /// </summary>
        /// <param name="point"></param>
        bool IsHit(IPoint point);
        /// <summary>
        /// соприкосновение с фигуруй
        /// </summary>
        /// <param name="gameObject"></param>
        bool IsHit(IGameObject gameObject);
    }
}
