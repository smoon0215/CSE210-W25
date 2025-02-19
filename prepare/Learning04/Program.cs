using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetName("Samuel Bennet ");
        assignment1.SetTopic("Mathematics");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignemt assignemt2 = new MathAssignemt();
        assignemt2.SetName("Roberto Rodriguez");
        assignemt2.SetTopic("Fractions");
        assignemt2.SetSection("7.3");
        assignemt2.SetProblems("8-19");
        Console.WriteLine(assignemt2.GetSummary());
        Console.WriteLine(assignemt2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetName("Mary Waters");
        assignment3.SetTopic("European History");
        assignment3.SetTitle("The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}