using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting account balance");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter deposits");
            int deposit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter withdrawls");
            int withdrawl = Convert.ToInt32(Console.ReadLine());
            SavingsAccount sa = new SavingsAccount(deposit, withdrawl, balance);
            sa.GetAnnualInterest(deposit, withdrawl, balance);

            











        }
        
        
      
    
       


    
}
