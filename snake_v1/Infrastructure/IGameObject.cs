using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public interface IGameObject:IDrawble
    {
        /// <summary>
        /// соприкосновение с точкой 
        /// </summary>
        /// <param name="point"></param>
       public bool IsHit(IPoint point);
        /// <summary>
        /// соприкосновение с фигуруй
        /// </summary>
        /// <param name="gameObject"></param>
       public bool IsHit(IGameObject gameObject);
    }
}
