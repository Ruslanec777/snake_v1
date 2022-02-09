using snake_v1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.BaseItems
{
    internal class SnakeTail : RigidBody
    {
        //public SnakeTail(Snake snake)
        //                :base(0,0)
        //{
        //    List<IPoint> tempIPoints = new();

        //    IPoint[] points = new IPoint[snake. Points.Count ];

        //    snake.Points.RemoveAt(0);
        //    Points.RemoveRange(Points.Count - 1, 1);
        //    Points.CopyTo(0, points, 0, Points.Count);
        //}

        //get
        //    {
        //        RigidBody TailRigidBody = new(0, 0);

        //IPoint[] points = new IPoint[Points.Count - 2];

        //Points.RemoveAt(0);
        //        Points.RemoveRange(Points.Count - 1 ,1);
        //        Points.CopyTo(0, points, 0, Points.Count );

        //        TailRigidBody.Figur.Points.Clear();
        //        TailRigidBody.Figur.Points.AddRange(points);

        //        return TailRigidBody;
        //    }
        public SnakeTail(int x, int y) : base(x, y)
        {
        }
    }
}
