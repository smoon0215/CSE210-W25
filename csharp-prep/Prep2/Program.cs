using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is your grade percentage? ");
       string valueFromUser = Console.ReadLine();

       int grade = int.Parse(valueFromUser);

       string letter = "";
       
       if (grade >= 90)
       {
        letter = "A";
       }
       else if (grade >=80)
       {
        letter = "B";
       }
       else if (grade >=70)
       {
        letter = "C";
       }
       else if (grade >=60)
       {
        letter = "D";
       }
       else
       {
        letter = "F";
       }

       Console.WriteLine($"Your grade is: {letter}");

       if (grade >= 70 )
       {
        Console.Write("Congradulations! You passed the class! ");
       }
       else
        {
            Console.Write("You did not pass the class. You learned, you will get it next time!");
        }
    }
}