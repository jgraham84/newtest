using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generictry
{
     public class Program
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        static void Main(string[] args)
        {
            //Test<int> t1 =new Test<int>();
            Test<int>.Add(10, 20);
        }
        }
         public class Test<T>
         {
         public static void Add <T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }

       
            
            
            
         public static void Sub<T>(T a, T b)
        { 

            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }

         public static void Mult<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);




        }
        public static void Div<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
            
        
        
           




        }


}
