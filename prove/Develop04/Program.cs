using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the main menu
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");

        // Get user input
        int choice = int.Parse(Console.ReadLine());

        // Instantiate appropriate activity based on choice
        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity(10, 5);
                breathingActivity.StartActivity();
                breathingActivity.BreathIn();
                breathingActivity.BreatheOut();
                breathingActivity.EndActivity();
                break;
            
            case 2:
                ReflectionActivity reflectionActivity = new ReflectionActivity(15);
                reflectionActivity.StartActivity();
                reflectionActivity.ShowRandomPrompt();
                reflectionActivity.AskReflectionQuestions();
                reflectionActivity.EndActivity();
                break;

            case 3:
                ListingActivity listingActivity = new ListingActivity(20);
                listingActivity.StartActivity();
                listingActivity.ShowRandomPrompt();
                listingActivity.ListItems();
                listingActivity.ShowItemCount(10);
                listingActivity.EndActivity();
                break;

            case 4:
                Console.WriteLine("Exiting program...");
                break;

            default:
                Console.WriteLine("Invalid choice. Exiting program...");
                break; 
        }
    }
}