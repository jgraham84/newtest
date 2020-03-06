using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Parent
    {
        public static void Method1()

        {
            Console.WriteLine("Public method");
        }
        private static void Method2()
        {

            Console.WriteLine("Private method");
        }


        protected static void method3()
        {
            Console.WriteLine("Private method");



        }
    }
}
