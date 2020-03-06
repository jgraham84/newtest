using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Triangle : Figure
    {
        public Triangle(double W, double H)
        {
            this.width = W;
            this.height = H;

        }
        public override double GetArea()
        {
            return (pi * radius);
        }
    }

}