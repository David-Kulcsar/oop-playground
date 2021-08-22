using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Classes
{
    class Rectangle : Shape
    {

        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override string GetName()
        {
            return "Rectangle";
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override double GetPerimeter()
        {
            return width * 2 + height * 2;
        }
    }
}
