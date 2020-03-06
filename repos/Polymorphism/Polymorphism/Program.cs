using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(10, 23);
            Add(200, 458);
            Add(200, 35, 654);
            Console.WriteLine(10, 23);
            Console.ReadLine();
        }

        public static int add(int a, int b) //method overload
        {
            int c = a + b;
            return c;
        
        
        }
        public static int Add(int a, int b, int c)
        {
            int d = a + b + c;
            return d;
       
        }
    }
}
