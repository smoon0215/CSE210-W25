using System.ComponentModel;

public class Outdoor : Event{

    public string WeatherForecast {get; set;}


    public Outdoor(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        :base(title, description, date, time, address){
            this.WeatherForecast = weatherForecast;
        }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nEvent TypeL Outdoor Gathering\nWeather Forecast {WeatherForecast}";
    }
}