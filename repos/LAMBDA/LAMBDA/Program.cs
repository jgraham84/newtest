using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<double, double> r1 = (x, y) =>
            {
                Console.WriteLine("Moneyinmybankaccount" + x * y);

            };

            r1(5,15) ;
            Func<double, double, double> t1 = (a, b) => 1000000-a-b;
            t1(1000, 2000);
            Console.WriteLine(t1(1000, 2000));
            Console.ReadLine();
        
        
        
        
        }
        
    
    
    
    }
}

