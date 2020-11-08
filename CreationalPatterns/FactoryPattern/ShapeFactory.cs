using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    class ShapeFactory
    {
        public ShapeFactory() { }
        public Shape GetShape(string shapeType)
        {
            if (shapeType.ToLower() == "circle") return new Circle();
            if (shapeType.ToLower() == "rectangle") return new Rectangle();
            if (shapeType.ToLower() == "square") return new Square();
            return null;
        }
    }
}
