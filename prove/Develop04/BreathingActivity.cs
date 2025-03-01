using System;

public class BreathingActivity : Activity{
    private int _breathingCycleTime;

    public BreathingActivity(int duration, int breathingCycleTime): base("Breathing Activity Started", "Breathing Activity Ended")
    {
        _breathingCycleTime = breathingCycleTime;
        Duration = duration.ToString();
    }

    public void StartBreathingSession(){
        Console.WriteLine("Start breathing session in...");
        ShowCountdown(3);
    }

    public void BreathIn(){
        Console.WriteLine("Breathe in...");
        ShowBreathingCountdown();
    }

    public void BreatheOut(){
        Console.WriteLine("Breathe out...");
        ShowBreathingCountdown();
    }

    private void ShowBreathingCountdown(){
        for (int i = 1; i <= 4; i++){

            Console.WriteLine(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}