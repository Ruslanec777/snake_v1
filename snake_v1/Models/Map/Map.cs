using snake_v1.Enums;
using snake_v1.Infrastructure;
using snake_v1.Models.BaseItems;
using snake_v1.Models.GeometricPrimitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.Map
{
    public class Map : RigidBody, IMap ,IMenuItem
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public string Name { get; set; }

        public IRigidBody Frut { get; set; }
        public string Text { get ; set ; }
        public Align AlignText { get ; set ; }

        public Vector2D BottomLeftEdge { get; set; }

        public Vector2D BottomRightEdge { get; set; }

        public Map(int x, int y, string name, IRectangle figur)
             : base(x, y,(IGeometricPrimitive) figur)
        {
            Name = name;
            Height = figur.Height;
            Width = figur.Width;
        }

        public void GenerateNewFruit()
        {
            Random rnd = new Random();
            Frut = new RigidBody(rnd.Next(StartPoint.X+1, StartPoint.X + Width-1), rnd.Next(StartPoint.Y+1, StartPoint.Y + Height-1), new PointGeomPrimit(ConsoleColor.Red , '$'));
            Frut.Draw();
        }
    }
}
