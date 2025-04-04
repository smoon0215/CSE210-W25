public class ChecklistGoal : Goal
{
    public int TargetCount { get; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; }

    public ChecklistGoal(string description, int points, int targetCount, int bonusPoints) 
        : base(description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override bool IsComplete() => CurrentCount >= TargetCount;

    public override void RecordProgress()
    {
        CurrentCount++;
        if (CurrentCount >= TargetCount)
        {
            Points += BonusPoints; // Add bonus points when goal is completed
        }
    }

    public override string ToString()
    {
        return $"{Description} (Completed {CurrentCount}/{TargetCount} times)";
    }
}
