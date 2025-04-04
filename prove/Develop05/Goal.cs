public abstract class Goal
{
    public string Description { get; set; }
    public int Points { get; set; }

    public Goal(string description, int points)
    {
        Description = description;
        Points = points;
    }

    public abstract bool IsComplete();
    public abstract void RecordProgress();
}
