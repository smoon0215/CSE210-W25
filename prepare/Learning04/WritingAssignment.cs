public class WritingAssignment: Assignment
{
    protected string _title = "";

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}