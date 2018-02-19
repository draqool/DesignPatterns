using System;

namespace AbstractFactory
{
    public class ShapeFactory
    {
        public IShape Create(ShapeEnum shapeEnum)
        {
            switch (shapeEnum)
            {
                case ShapeEnum.Circle:
                    return new Circle();
                case ShapeEnum.Rectangle:
                    return new Rectangle();
                case ShapeEnum.Square:
                    return new Square();
                default:
                    throw new MissingMemberException();
            }
        }
    }
}