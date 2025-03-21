public interface IGoal
{
    string Description { get; }
    int Points { get; }
    bool IsComplete();
    void RecordProgress();
}