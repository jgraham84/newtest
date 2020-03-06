using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectToClass
{
    class Program
    {
        static void Main(string[] args)
        {





            List<Person> p1 = new List<Person>();

            Person p2 = new Person { id = 101, FirstName = " Paul", LastName = " Smith", Age = 21 };
            
            Person p3 = new Person { id = 102, FirstName = " Kyle", LastName = "Johnson", Age = 22 };
            Person p4 = new Person { id = 103, FirstName = " Josh", LastName = "Graham", Age = 23 };
            Person p5 = new Person { id = 104, FirstName = " Jordan", LastName = "Sanders", Age = 24 };
            Person p6 = new Person { id = 105, FirstName = " Zack", LastName = " Rogers", Age = 25 };
            Person p7 = new Person { id = 106, FirstName = " Roger", LastName = "Smith-Shuster", Age = 26 };

            

            p1.Add(p2);
            p1.Add(p3);
            p1.Add(p4);
            p1.Add(p5);
            p1.Add(p6);
            p1.Add(p7);

            foreach (Person obj in p1)
            {
                //Console.WriteLine(obj.id + ":" + obj.FirstName + obj.LastName + obj.Age);
                Console.WriteLine($"objId: {obj.id}, FirstName: {obj.FirstName}, LastName: {obj.LastName}, Age: {obj.Age}");

            }

            Console.ReadLine();






















        }
    }

}