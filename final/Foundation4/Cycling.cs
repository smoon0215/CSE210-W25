using System.Diagnostics.Contracts;

public class Cycling : Activity{
    public double SpeedInMPH {get; private set;}

    public Cycling(DateTime date, int durationInMinutes, double speedInMPH)
        :base(date, durationInMinutes){
            SpeedInMPH = speedInMPH;
    }

    public override double GetDistance()
    {
        return (SpeedInMPH * DurationInMinutes) /60 ; // Distance in miles 
    }

    public override double GetSpeed()
    {
        return SpeedInMPH; 
    }

    public override double GetPace()
    {
        return 60 / SpeedInMPH; // Pace in min per mile 
    }
}