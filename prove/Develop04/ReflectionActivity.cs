using System; 
using System.Collections.Generic;

public class ReflectionActivity : Activity{

    private List<string> _promptsList;
    private List<string> _questionsList;

    public ReflectionActivity(int duration) : base("Reflection Activity Started", "Reflection Activity Ended")
    {
        Duration = duration.ToString();
        _promptsList = new List<string> {"Think of a time when you stood up for someone else", "Think of a time when you did something really difficult", "Think of a time when you helped someone in need", "Think of a time when you did something selfless"};
        _questionsList = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was done?", "What made this time different than othe times when you were not as successful",
        "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    }

    public void StartReflectionSession(){
        Console.WriteLine("Starting Reflection Session...");
        ShowCountdown(3);
    }

    public void ShowRandomPrompt(){
        Random rand = new Random();
        int index = rand.Next(_promptsList.Count);
        Console.WriteLine(_promptsList[index]);
    }

    public void AskReflectionQuestions(){
        foreach (var question in _questionsList){
            Console.WriteLine(question);
        }
    }

    public void StartActivity(){
        base.StartActivity();
        StartReflectionSession();
    }   

    public void EndActivity(){
        base.EndActivity();
    }
}