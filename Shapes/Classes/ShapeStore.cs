using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Classes
{
    public class ShapeStore : IShapeStore
    {
        private List<Shape> shapes;

        public ShapeStore()
        {
            shapes = new List<Shape>();
        }

        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        public void Remove()
        {
            shapes = null;
        }

        public List<Shape> List()
        {
            return shapes;
        }

        
    }
}
