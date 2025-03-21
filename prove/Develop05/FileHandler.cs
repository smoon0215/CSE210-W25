using System;
using System.Collections.Generic;
using System.IO;

public class FileHandler
{
    public void SaveGoals(List<IGoal> goals, int totalPoints){
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals){
                
                string goalType = goal.GetType().Name;
                string goalData = goal switch
                {
                    SimpleGoal simple => $"{goalType}:{simple.Description},{simple.Points},{simple.Completed}",
                    EternalGoal eternal => $"{goalType}:{eternal.Description},{eternal.Points}",
                    ChecklistGoal checklist => $"{goalType}:{checklist.Description},{checklist.Points},{checklist.TargetCount},{checklist.CurrentCount},{checklist.BonusPoints}",
                    _ => throw new InvalidOperationException("Unknown Goal Type")
                };
                outputFile.WriteLine(goalData);
            }
            outputFile.WriteLine(totalPoints);
        }
    }

    public (List<IGoal>, int) LoadGoals(){

        var goals = new List<IGoal>();
        int totalPoints = 0;

        if (File.Exists("goals.txt"))
        {
            using (StreamReader inputFile = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    if (int.TryParse(line, out int points))
                    {
                        totalPoints = points;
                    }
                    else 
                    {
                        string[] parts = line.Split(';');
                        string goalType = parts[0];
                        string[] data = parts[1].Split(',');

                        switch (goalType)
                        {
                            case nameof(SimpleGoal):
                                goals.Add(new SimpleGoal(data[0], int.Parse(data[1])));
                                break;
                            case nameof(EternalGoal):
                                goals.Add(new EternalGoal(data[0], int.Parse(data[1])));
                                break;
                            case nameof(ChecklistGoal):
                                goals.Add(new ChecklistGoal(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[4])) { CurrentCount = int.Parse(data[3]) });
                                break;
                            default:
                                throw new InvalidOperationException("Unknown Goal Type");
                        }
                    }
                }
            }
        }
        return (goals, totalPoints);
    }

}