using Shapes.Classes;
using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IShapeStore shapeStore = new ShapeStore();

            shapeStore.Add(new Square(2));
            shapeStore.Add(new Rectangle(3, 4));
            shapeStore.Add(new Circle(5));

            List<Shape> shapeList = shapeStore.List();

            foreach(Shape shape in shapeList) {
                Console.WriteLine(shape.GetName() + ": Area=" + shape.GetArea() + ", Perimeter=" + shape.GetPerimeter());
            }
        }
    }
}
