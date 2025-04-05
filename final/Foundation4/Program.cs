// I used ChatGPT to help with some structure and basic guidance, but implementation and adjustments were made based on what I’ve learned during the course.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create some example activities
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0), // Running for 30 minutes with a distance of 3 miles
            new Cycling(new DateTime(2022, 11, 3), 45, 12.0), // Cycling for 45 minutes at 12 mph
            new Swimming(new DateTime(2022, 11, 3), 40, 40)   // Swimming for 40 minutes with 40 laps
        };

        // Iterate over activities and print summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
