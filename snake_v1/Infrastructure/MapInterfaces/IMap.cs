﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    public interface IMap : IRigidBody, IRectangle
    {
        string Name { get; }
        IRigidBody Frut { get; set; }

        void GenerateNewFruit();

        /// <summary>
        /// соприкосновение с картой 
        /// </summary>

    }
}
