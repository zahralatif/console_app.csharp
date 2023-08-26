using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Circle : Shape
    {
        public Circle(double radius) : base(radius, 0, 0) { }

        public override double GetArea()
        {
            return Math.PI * side * side;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * side;
        }
    }
}
