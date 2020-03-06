using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter number");
            int a = Convert.ToInt32(Console.ReadLine());

            String day = "";
            switch (a)
            {


                case 1:
                    day = " Monday";
                    break;

                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
            }
                    Console.WriteLine(day);
                    Console.ReadLine();


            }
            
    }
}
