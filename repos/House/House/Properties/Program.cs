using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 l1 = newmodel1();
            //Object creation for Class model1
           
            
            newmodel1 z2 = new newmodel1("mod2", 40000);
            newmodel1 z3 = new newmodel1("mod3", 50000);
            Console.WriteLine(z2.name + "" + z2.Price);
            Console.WriteLine(z3.name + ""  + z3.Price);
            Console.ReadLine();







        }
        class newmodel1
        {
            public string name = "Apex";
            public double price = 30000;
            public string Mode1;
        



        
        
        
        
        
        
        class model1
    {

            public string name = "mod1";
            public double price;

            public model1(String n, double x)
            {
                this.price = x;
                this.name = n;




            }
    }
    



           
           
           
        
        
        
        
        
        
        
        
    }
    }
}
