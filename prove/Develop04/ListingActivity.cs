using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    
    private List<string> _promptsList;
    private List<string> _itemsList;
    private int _duration;

    
    public ListingActivity(int duration)
        : base("Listing Activity Started", "Listing Activity Ended")
    {
        _duration = duration;
        Duration = duration.ToString();
        _promptsList = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people you have helped this week?", 
        "When have you felt the Holy Ghost this month?", "Who are some of your personal heros?"};
        _itemsList = new List<string>();
    }

    
    public void StartListingSession()
    {
        Console.WriteLine("Get ready to start listing...");
        ShowCountdown(3); // Countdown before starting
        Console.WriteLine("Now, start listing items related to the prompt.");
    }

    public void ShowRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_promptsList.Count); //Choose random prompt
        Console.WriteLine(_promptsList[index]); // Display
    }

    public void ListItems()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration); // Set end time based on duration

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter an item (or type 'done' to stop early):");
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
            {
                break; // Allow the user to stop early by typing "done"
            }
            _itemsList.Add(item); // Add the item to the list
        }

        // Show the item count after the time is up or when the user types 'done'
        ShowItemCount(_itemsList.Count);
    }

    public void ShowItemCount(int itemCount)
    {
        Console.WriteLine("Total items listed: " + itemCount); // Display total number of items listed
    }

    public void StartActivity()
    {
        base.StartActivity();
        StartListingSession();
        ShowRandomPrompt();
        ListItems(); 
    }

    public void EndActivity()
    {
        base.EndActivity();
    }
}
