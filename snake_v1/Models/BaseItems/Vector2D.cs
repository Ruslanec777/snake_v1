﻿using System;

namespace snake_v1.Models.BaseItems
{
    /// <summary>
    /// представляет вектор из начала координат до точки X,Y
    /// </summary>
    public class Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector2D Sub(Vector2D vector2D)
        {
            return new Vector2D(X - vector2D.X, Y - vector2D.Y);
        }

        public Vector2D Sum(Vector2D vector2D)
        {
            return new Vector2D(X + vector2D.X, Y + vector2D.Y);
        }

        public Vector2D Abs()
        {
            return new Vector2D(Math.Abs(X), Math.Abs(Y));
        }
    }
}
