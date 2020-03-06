using System;

namespace randomized_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string Word = "Claim";

            string newword = "";

            for (int i = 0; 1 < Word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    //new word += str.toUpperCase().charAt(i)); 
                    newword += Word[i].ToString().ToUpper();
                }
                else
                { 
                    newword += Word[i].ToString().ToLower();
                }
            }





                    Console.WriteLine(newword);
        }
        
            
            
            //Console read line
    
    }
}
