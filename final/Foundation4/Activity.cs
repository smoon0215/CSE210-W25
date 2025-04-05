public abstract class Activity{

    public DateTime Date {get; private set;}
    public int DurationInMinutes {get; private set;}

    public Activity(DateTime date, int durationInMinutes){
        Date = date; 
        DurationInMinutes = durationInMinutes;
    }


    // Virtual methods to be overridden in the derived classes.
    public virtual double GetDistance(){
        return 0; 
    }

    public virtual double GetSpeed(){
        return 0;
    }

    public virtual double GetPace(){
        return 0;
    }

    public string GetSummary(){
        return $"{Date: dd MM yyyy} {this.GetType().Name} ({DurationInMinutes} min): Distance {GetDistance(): 0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min per miles";
    }
}