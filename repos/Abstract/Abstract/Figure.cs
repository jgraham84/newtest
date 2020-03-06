using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    // A method without any method body is known as abstract method
    //A class which contains any abstract members in it is called abstract clas


     public abstract class Figure
    {
        public double width, height, radius;
        public float pi = 3.14f;
        // Abstract method
        public abstract double GetArea();
    }
}
