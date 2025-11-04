using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_And_Interfaces.Shapes
{
    public class Rectangle : IShape
    {
        //fields 
        public double height;
        public double width;

        //constructor

        public Rectangle(double h, double w)
        {
            height = h;
            width = w;
        }

        //methods
        public double CalculateArea()
        {
            return height * width;
        }

        public double CalculatePerimeter()
        {
            return 2*height + 2*width;
        }
    }
}
