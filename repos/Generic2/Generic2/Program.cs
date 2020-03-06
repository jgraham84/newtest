using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    class Program
    {
        public static void Add<T>(T a, T b)
        {
            //Datatype of the variable is declared at runtime
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);


        }

        public static void Sub<T>(T a, T b)
        {
            //Datatype of the variable is declared at runtime
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);

        }






        public static void Div<T>(T a, T b)
        {
            //Datatype of the variable is declared at runtime
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }

        public static void Mul<T>(T a, T b)
        {
            //Datatype of the variable is declared at runtime
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }





        public static void Main(string[args])
        {
            Add<double>(10.34, 34.43);

          

           }

    }
}


          