using System;
using System.Collections.Generic;

public class GoalManager
{
    public List<IGoal> Goals { get; private set; }
    public int TotalPoints { get; set; }

    public GoalManager()
    {
        Goals = new List<IGoal>();
        TotalPoints = 0;
    }

    public void AddGoal(IGoal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < Goals.Count)
        {
            var goal = Goals[index];
            goal.RecordProgress();
            TotalPoints += goal.Points;
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine("Goals:");
            var goal = Goals[i];
            Console.WriteLine($"{i + 1}. {goal.Description} - {(goal.IsComplete() ? "[X]" : "[ ]")} - {goal.Points} points");
            Console.WriteLine();
        }
    }
}