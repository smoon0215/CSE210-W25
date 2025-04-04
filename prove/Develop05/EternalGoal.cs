public class EternalGoal : Goal
{
    public EternalGoal(string description, int points) : base(description, points) { }

    public override bool IsComplete() => false;

    public override void RecordProgress()
    {
        // Accumulate points every time the goal is completed
        Points += 100; // Add points each time an event is recorded
    }
}
