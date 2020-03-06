using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymousmethod
{
    class Program
    {
        //Delegate: Its a type safe function/method pointer
        // Holds the reference of a method and then calls the method for execution
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Add(100, 50);
            Console.WriteLine(Hello("Roger"));
            Console.ReadLine();
            Hello("Roger");
            AddDelegate ad = new AddDelegate(p1.Add);
            HelloDelegate hd = new HelloDelegate(Hello);

        }


        public delegate void AddDelegate(int a, int b);
        public delegate string HelloDelegate(string str);
         
        public void Add(int a,int b)
        {
            Console.WriteLine(a + b);

        }
        public static string Hello (string name)
        {
            return "Hello" + name;
        }
    }
}
