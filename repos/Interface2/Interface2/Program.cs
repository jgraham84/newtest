using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Program :iFirst, iSecond
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Test();
            //Reference of interface
            iFirst il =p1;
            il.show();
            Console.WriteLine("Hello world");
        }

        public void show();
        
        
        public void Test()
        {
         
        
        }
    }
}
