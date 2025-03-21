using System; 
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;

public class ChecklistGoal : Goal 
{
    public int TargetCount {get; }  
    public int CurrentCount {get; set;}
    public int BonusPoints {get; }

    public ChecklistGoal(string description, int points, int targetCount, int bonusPoints){
        Description = description; 
        Points = points;
        TargetCount = targetCount;
        BonusPoints = bonusPoints; 
        CurrentCount = 0;
    }

    public override bool IsComplete() => CurrentCount >= TargetCount;

    public override void RecordProgress(){
        CurrentCount++;
        if (CurrentCount >= TargetCount){
            Points += BonusPoints;
        }
    }

    public override string ToString()
    {
        return $"{Description} (Completed {CurrentCount}/{TargetCount} times)";
    }
}