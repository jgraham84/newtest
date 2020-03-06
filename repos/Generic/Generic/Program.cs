using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
       
        public static bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }


        
        
             static void Main(string[] args)
        {
                bool result = Compare(10, 20);
                bool result1 = Compare("Roger", "Roger");
                bool RESULT2 = Compare(12.4, 13.4);
                bool reslut3 = Compare('m', 'm');


        }
    }
}
