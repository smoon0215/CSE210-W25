using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int fav_number = PromptUserNumber();
        int square_fav_number = SquareNumber(fav_number);

        DisplayResult(name, square_fav_number);
    }



        static void DisplayWelcome()
        {
           Console.WriteLine("Welcome to the program!"); 
        }
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            return name; 
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int fav_number = int.Parse(Console.ReadLine());

            return fav_number;
            
        }
        static int SquareNumber(int fav_number)
        {
            int square_fav_number = fav_number * fav_number;

            return square_fav_number;
            
        }
        static void DisplayResult(string name, int square_fav_number)
        {
            Console.WriteLine($"{name} the square of your number is {square_fav_number}");

        }
}