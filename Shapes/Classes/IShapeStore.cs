using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Classes
{
    public interface IShapeStore
    {

        void Add(Shape shape);

        void Remove();

        List<Shape> List();
    }
}
