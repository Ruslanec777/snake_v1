using snake_v1.Enums;
using System;

namespace snake_v1.Infrastructure
{
    internal interface ILine
    {
        public int Length { get; set; }
        public LineType TypeLine { get; set; }
        public ConsoleColor Color { get; set; }
    }
}
