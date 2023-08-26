using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shape
{
    public abstract class Shape
    {
        protected double side;
        protected double length;
        protected double width;

        public Shape(double side, double length, double width)
        {
            this.side = side;
            this.length = length;
            this.width = width;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}