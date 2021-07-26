using System;
using System.Collections.Generic;
using Interface3.Model.Enums;
using System.Globalization;

namespace Interface3.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle Color" +
                 Color +
                 ", Radius = " +
                 Radius.ToString("F2", CultureInfo.InvariantCulture) +
                 ", Area = " +
                 Area().ToString("F2", CultureInfo.InvariantCulture); 

        }
    }
}
