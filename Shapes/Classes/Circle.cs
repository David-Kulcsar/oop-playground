using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Classes
{
    class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override string GetName()
        {
            return "Circle";
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
