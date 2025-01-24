using System;

public class Job{
    public string _jobCompany;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobCompany}, {_jobTitle}, {_startYear} - {_endYear}");
    }
}

