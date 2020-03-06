using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultitaskDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Rectangle ad = new Rectangle(p1.GetArea);
        }

        public delegate void Rectangle(double a, double b);

        public void GetArea(double a, double b);



        Console.WriteLine("AreaofTheRectangle" + 0.5 * a* b));
    
           
          public void GetPerimeter(Double a, Double b);
          
         Console.WriteLine"(Perimeterofthetriangle" +2* (a* b));
         
        
    


    }
}
