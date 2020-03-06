using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Circle :Figure
    {
        public Circle(double R)
        {
            this.radius = R;
        }

        public override double GetArea()
        {
            return (pi * radius);
        }
   
    }
}
