using System;
using System.Collections.Generic;

public class GoalManager
{
    public List<Goal> Goals { get; private set; }
    public int TotalPoints { get; set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
        TotalPoints = 0;
    }

    public void AddGoal(Goal goal)
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
            var goal = Goals[i];
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            string progress = goal is ChecklistGoal checklistGoal
                ? $"Completed {checklistGoal.CurrentCount}/{checklistGoal.TargetCount} times"
                : string.Empty;

            Console.WriteLine($"{i + 1}. {goal.Description} - {status} - {goal.Points} points {progress}");
        }
    }
}
