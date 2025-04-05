public class Running : Activity{
    public double DistanceInMiles { get; private set; }

    public Running(DateTime date, int durationInMinutes, double distanceInMiles)
        :base(date, durationInMinutes){

            DistanceInMiles = distanceInMiles;
        }

    public override double GetDistance()
    {
        return DistanceInMiles;
    }

    public override double GetSpeed()
    {
        return (DistanceInMiles / DurationInMinutes) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return DurationInMinutes / DistanceInMiles; // Pace in min per mile
    }
}