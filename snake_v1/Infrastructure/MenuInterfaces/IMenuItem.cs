using snake_v1.Enums;
using snake_v1.Models.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public interface IMenuItem : IDrawble, IDeleteble, IStartPoint, IRectangle
    {
        public string Text { get; set; }

        public Align AlignText { get; set; }

        public string Name { get; set; }

        public Vector2D BottomLeftEdge { get; }
        public Vector2D BottomRightEdge { get; }
    }
}
