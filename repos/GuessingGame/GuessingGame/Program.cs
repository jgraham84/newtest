using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
//# Guessing Game
//# Generate a random number between 1 - 10
//# Handle User guesses
//# If they guess correct, tell them that they won
//# Otherwise tell them if they are too high or too low

//# BONUS	- let the player play again if they want!







    class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("Welcome to Guessing Game: Pick a number between 1-10");



                Random rand_num = new Random();
                int num = rand_num.Next(1, 10);

                var user_input = Console.ReadLine();

                if (Convert.ToInt32(user_input) == num)
                {
                    Console.WriteLine("You Won");
                    Console.ReadLine();
                }
                else if (Convert.ToInt32(user_input) < num)
                {
                    Console.WriteLine("You Lost");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You're too high");
                    Console.ReadLine();
                }



            //    Console.ReadLine();
            bool hasduplicate = false;
            int[] array2 = new int[] { 1, 3, 5, 7, 8, 11, 13};
            int[] array3 = new int[] { 1, 3, 5, 7, 9, 10, 12 };

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    for (int j = 0; j < array3.Length; j++)
            //    {

            //        if (array2 == array3)
            //        {
            //            hasduplicate = true;
            //            Console.ReadLine();
            //        }                 

            //    }

            //}
            int[] dupsFound = new int[]{ };
            foreach(var numberA in array2)
            {
                foreach(var numberB in array3)
                {
                    if(numberA == numberB)
                    {
                        hasduplicate = true;
                        
                        Console.WriteLine(hasduplicate);
                        Console.ReadLine();
                    }
                }
            }
            Console.ReadLine();


        }
   
           
    }
}