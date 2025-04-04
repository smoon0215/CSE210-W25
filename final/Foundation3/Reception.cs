public class Reception : Event{

    public string RsvpEmail{ get; set; }

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        :base(title, description, date, time, address){
            this.RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nEvent Type: Reception\nRSVP Email: {RsvpEmail}";
    }
}