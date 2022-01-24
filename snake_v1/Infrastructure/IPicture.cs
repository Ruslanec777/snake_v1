using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Infrastructure
{
    internal interface IPicture
    {
        public ConsoleColor Color { get; set; }

        public char CharOfPicture { get; set; }

    }
}
