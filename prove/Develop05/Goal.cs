public abstract class Goal : IGoal
{
    public string Description {get; protected set; }
    public int Points {get; protected set;}

    public abstract bool IsComplete();
    public abstract void RecordProgress();
}