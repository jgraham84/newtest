using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic3
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

            {





                 static void Div<T>(T a, T b)
                {
                    //Datatype of the variable is declared at runtime
                    dynamic d1 = a;
                    dynamic d2 = b;
                    Console.WriteLine(d1 / d2);
                }

                static void Mul<T>(T a, T b)
                {
                    //Datatype of the variable is declared at runtime
                    dynamic d1 = a;
                    dynamic d2 = b;
                    Console.WriteLine(d1 * d2);
                }























                static void Main(string[] args)
        {
        }
    }
}
