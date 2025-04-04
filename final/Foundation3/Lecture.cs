public class Lecture : Event{

    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.Speaker = speaker;
        this.Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nEvent Type: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}


