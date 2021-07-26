using System;
using Interface3.Model.Enums;

namespace Interface3.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
