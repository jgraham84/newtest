using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    //Searching a value in an array-loops and logic-CRUD--LINQ
    //Array, collections,databases,Tables,Databasets, XML--Extensible Markup language
    //Select <col> From that <Table>
    class Program
    {
        //test
        //test1dhjgdjdfjfd
        
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 40, 50, 70, 90, 80 };
            var numbers = from i in array
                          where i < 40
                          orderby i
                          descending
                          select i;
            foreach(int x in numbers)
            {
                Console.WriteLine(x + "");
            }
            Console.ReadLine();    
        }
    }
}
