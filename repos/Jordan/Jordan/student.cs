using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jordan
{
    class student
    {
        static void Main(string[] args)
        { }


         public string fName, lName, address, state, age, zipCode, visa;

        public student()
        {
            this.fName = "";
            this.lName = "";
            this.address = "";
            this.state = "";
            this.age = "";
            this.zipCode = "";
            this.visa = "";

        }

        public student(string fn, string ln, string adr, string st, string a, string zip, string vis)
        {
            this.fName = fn;
            this.lName = ln;
            this.address = adr;
            this.state = st;
            this.age = a;
            this.zipCode = zip;
            this.visa = vis;
        }

        public void DisplayInfo()
        {
            int fee = (state == "MO") ? fee = 12500 - 10000 : fee = 12500;
            Console.WriteLine(fName + " " + lName + "'s address is: " + address + ", " + state + ", " + zipCode + " and has " +
                                visa + " VISA. Fee: " + fee);
        }
    }
}

// MAIN


namespace CSharpReview
{
    class Students
    {
        static void Main(string[] args)
        {
            // Create an array of 5 students
            Students[] students = new Students[5];

            // Create a for loop to enter data 5 times
            for (int i = 0; i < 5; i++)
            {

                // Create instance of students
                students[i] = new Students();

                Console.WriteLine("Enter Student " + (i + 1) + "  first name: ");
                students[i].fName = Console.ReadLine();
                Console.WriteLine("Enter Student " + (i + 1) + "  last name: ");
                students[i].lName = Console.ReadLine();
                Console.WriteLine("Enter Student " + (i + 1) + "  address: ");
                students[i].address = Console.ReadLine();
                Console.WriteLine("Enter Student " + (i + 1) + "  state: ");
                students[i].state = Console.ReadLine();
                Console.WriteLine("Enter Student " + (i + 1) + "  age: ");
                students[i].age = Console.ReadLine();
                Console.WriteLine("Enter Student " + (i + 1) + "  zip code: ");
                students[i].zipCode = Console.ReadLine();
                Console.WriteLine("Enter Student " + (i + 1) + "  visa status: ");
                students[i].visa = Console.ReadLine();

               
                
                
                
                
                
                // Display results
                students[i].DisplayInfo();
            }

            Console.ReadKey();

            Console.WriteLine("display");
            Console.ReadLine("name");





        }
    }
}
