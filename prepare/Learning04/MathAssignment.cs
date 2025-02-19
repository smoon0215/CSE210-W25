public class MathAssignemt : Assignment
{
    protected string _textbookSection = "";
    protected string _problems =  "";

    public string GetTextbookSelection()
    {
        return _textbookSection;
    }

    public void SetSection(string section)
    {
        _textbookSection = section;
    } 

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}