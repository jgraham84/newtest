using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Action<double, double> r1 = p1.GetArea;
            Func<double, double, double> r2 = p1.GetPerimeter;


            r1(5, 2);

        }


        public void GetArea(double a, double b)

        {
            Console.WriteLine("Area of the rectangle" + a * b);
        }
       
        
        
        
        
        
        public double GetPerimeter(double a, double b);
    
    
    
    
    }
}