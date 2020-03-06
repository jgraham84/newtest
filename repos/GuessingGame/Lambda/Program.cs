using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{

    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + string.IsNullOrEmpty(MiddleName) + LastName;
    }
    
    namespace ConsoleApp1
    {
        class Program
        {
            #region StaticFields
            private static List<int> _integers = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5, 9 };

            private static List<string> _strings = new List<string> {
            "Hello",
            "World!",
            "I",
            "am",
            "a",
            "list",
            "of",
            "strings",
        };

            #endregion

            #region StaticMethods
            static int Aggregate(Func<int, int, int> f, List<int> list)
            {
                int result = list[0];
                for (int i = 1; i < list.Count; ++i)
                {
                    result = f(result, list[i]);
                }

                return result;
            }

            static IEnumerable<int> Select(Func<int, int> f, IEnumerable<int> list)
            {
                List<int> result = new List<int>();
                foreach (int val in list)
                {
                    result.Add(f(val));
                }
                return result;
            }

            static void ForEach<T>(Action<T> f, IEnumerable<T> list)
            {
                foreach (T val in list)
                {
                    f(val);
                }
            }

            #endregion

            static int Sum(int a, int b) => a + b;
           static int Multiply(int a, int b) => a * b;
            static int MakeDouble(int Bozo) =>Bozo * 2;
            static int Square(int X) => X * X;
            static void Main(string[] args)
            
            {

                




                //1A.Write a method called Sum that takes two int parameters, and returns the sum of the parameters.For example, Sum(5, 7) should return 12. 
                //	Inside the Main method, call Aggregate, passing in the Sum method and the _integers field.
                //    Print the result that Aggregate returns.
                
                Console.WriteLine(Aggregate(Sum, _integers));


                //1B.Create another method called Multiply, which also takes two ints and returns an int, but multiplies its parameters instead of adding them. For example, Multiply(5, 7) should return 35.
                //	Inside the Main method, call Aggregate, passing in the Multiply method and the _integers field.
                //    Print the result that Aggregate returns. 
               Console.WriteLine(Aggregate(Multiply, _integers));

                //1C.Call Aggregate again, but this time do NOT pass in a named method (Sum or Multiply). Instead, use a lambda expression that does the same thing that Sum did.
                //   Print the result that Aggregate returns.
                //Aggregate((a, b) => a + b, _integers);
                Console.WriteLine(Aggregate((a, b) => a + b, _integers));
                //1D. Call Aggregate one more time, with a different lambda expression that does the same thing that Multiply did.
                //   Print the result that Aggregate returns.
                //Aggregate((a, b)=> a*b,_integers);
                Console.WriteLine(Aggregate((a, b) => a * b, _integers));
                //2A.Create a method called MakeDouble that takes a single int parameter, and returns the parameter multiplied by 2. For example, MakeDouble(5) should return 10. 
                //	Inside Main, call Selectpassing in the MakeDouble method and the _integers field.
                //    Print the result that MakeDouble returns.
                foreach(int num in Select(MakeDouble, _integers))
                    Console.Write(num + ", "); ;
                
                //2B.Create a method called Square that takes a single int parameter, and returns the parameter multiplied by itself.For example, Square(5) should return 25. 
                //	Inside Main, passing in the Square method and the _integers field.
                //    Print the result that Map returns.
                Select(Square, _integers);
                Console.WriteLine(Select(Square, _integers));
                //2C.This time do NOT pass in a named method (MakeDouble or Square). Instead, use a lambda expression that does the same thing that MakeDouble did.
                //   Print the result that returns.
                //2D. Call MakeDouble one more time, this time with a lambda expression that does the same thing that Square did.
                //   Print the result that Map returns.
                Console.ReadLine();
            }
        }
    }
}




