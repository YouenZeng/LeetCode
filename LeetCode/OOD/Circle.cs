using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.OOD
{
    class Circle : Shape
    {
        private int radiusCircle ;

        public Circle(string name, int radius) : base(name)
        {
            this.radiusCircle = radius;
        }
    }
}