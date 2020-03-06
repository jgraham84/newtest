using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //Class-User defined datatype

    //Interface-this is also a user-defined data type.

    //Class-Non abstract methods(Methods with method body
    //Abstract-non abstract methods and also abstract methods(without body)


    //Interface-Contains only abstract methods(without body) same as abstract class.
    //Every abstract methos of an interface should be implemented by the child class
    //of the interface without fail
    class Program : Ifirsts, iSecond
    {
        static void Main(string[] args)
        {

            Program p1 = new Program();//Instance of the class to use the new method
            p1.Add(10, 35);
            Console.ReadLine();
        }

        public void Add(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Addition is" + c);

        }    
            
          throw new NotImplementedException();
    
    }
}
