public class SimpleGoal : Goal
{
    public bool Completed { get; set; }

    public SimpleGoal(string description, int points) : base(description, points)
    {
        Completed = false;
    }

    public override bool IsComplete() => Completed;

    public override void RecordProgress()
    {
        Completed = true;
    }
}
