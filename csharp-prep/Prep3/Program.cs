using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {        
        Random number = new Random();
        int magic_number = number.Next(1,100);
        int user_guess = -1;
        
        while (user_guess != magic_number)
        {
            Console.WriteLine("What is your guess?");
            user_guess = int.Parse(Console.ReadLine());

            if (user_guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (user_guess < magic_number)
            {
                Console.WriteLine("Higher");
            } 
            else
            {
                Console.WriteLine("You guessed it! ");
            }
        }

    }
}