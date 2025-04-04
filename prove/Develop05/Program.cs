using System;
using System.Collections.Generic;
using System.IO;
//W00F

public class Program
{
    private static GoalManager goalManager = new GoalManager();
    private static FileHandler fileHandler = new FileHandler();

    public static void Main()
    {
        // Load existing goals if any
        LoadGoals();

        // Display menu
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine($"Total Points: {goalManager.TotalPoints}");
            goalManager.DisplayGoals();
            Console.WriteLine("---------------");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("---------------");

            switch (Console.ReadLine())
            {
                case "1":
                    AddNewGoal();
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                    break;
                case "3":
                    SaveGoals();
                    Console.WriteLine("Goals saved successfully.");
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                    break;
                case "4":
                    LoadGoals();
                    Console.WriteLine("Goals loaded successfully.");
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    return;
            }
        }
    }

    private static void AddNewGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?: ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                goalManager.AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for it to be completed and bonus points awarded?: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times?: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Enter the number of the goal you completed:");
        int index = int.Parse(Console.ReadLine()) - 1;
        goalManager.RecordEvent(index);
        Console.WriteLine("Event recorded successfully.");
    }

    private static void SaveGoals()
    {
        fileHandler.SaveGoals(goalManager.Goals, goalManager.TotalPoints);
    }

    private static void LoadGoals()
    {
        var (goals, totalPoints) = fileHandler.LoadGoals();
        goalManager.Goals.AddRange(goals);
        goalManager.TotalPoints = totalPoints;
    }
}