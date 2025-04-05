using System.Reflection.Metadata.Ecma335;

public class Swimming : Activity {
    public int Laps {get; private set; }

    public Swimming(DateTime date, int durationInMinutes, int laps)
        :base(date, durationInMinutes){
            Laps = laps;
        }

    public override double GetDistance()
    {
        return (Laps*50*0.000621371); // 50 meters per lap, convert to miles (50*0.000621371)
    }

    public override double GetSpeed()
    {
        return (GetDistance()/DurationInMinutes)*60; // Speed in MPH
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance(); // min per mile 
    }
}