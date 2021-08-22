using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Classes
{
    public class Square : Shape
    {
        private readonly double width;
        public Square(double width)
        {
            this.width = width;
        }

        public override string GetName()
        {
            return "Square";
        }

        public override double GetArea()
        {
            return width * width;
        }

        public override double GetPerimeter()
        {
            return width * 4;
        }
    }
}
