using System;
using System.Runtime.InteropServices;

public class Activity{

    // List of Attributes 
    private string _duration;
    private string _endMessage;
    private string _startMessage; 

    public string Duration{
        get {return _duration; }
        set {_duration = value; }
    }

    public string EndMessage{
        get {return _endMessage; }
        set {_endMessage = value; }
    }

    public string StartMessage{
        get {return _startMessage; }
        set {_startMessage = value; }
    }

    public Activity(string startMessage, string endMessage){
        _startMessage = startMessage;
        _endMessage = endMessage;
    }

    public void StartActivity(){
        Console.WriteLine(StartMessage);
        ShowCountdown(3);
        Console.WriteLine("Please set the duration for your activity in seconds:");
        Duration = Console.ReadLine(); // Get duration from user input
        Console.WriteLine($"Starting activity for {Duration} seconds...");
        ShowCountdown(3);
    }

    public void EndActivity(){
        ShowCountdown(3);
        Console.WriteLine("Activity ended: "+_endMessage);
        Console.WriteLine("You spent " +Duration+ "seconds on this activity.");
    }

    public void PauseActivity(int seconds){
        Console.WriteLine("Activity paused for " +seconds+ "seconds.");
    }

    public void DisplayMessage(string message){
        Console.WriteLine(message);
    }

    // Method to show countdown w/ animation 
    protected void ShowCountdown(int countdownLimit){
        for (int i = 1; i <= countdownLimit; i++)
    {
        Console.Write(". ");
        System.Threading.Thread.Sleep(1000); // Simulating spinner delay
    }
    Console.WriteLine();
    }
}