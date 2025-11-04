using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_And_Interfaces.Shapes
{
    public class Circle : IShape
    {
        //field
        public double Radius;

        //constructor
        public Circle(double r) 
        {
            Radius = r;
        }


        //methods
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
