public class Address
{
    public string StreetAddress {get; set;}
    public string City {get; set;}

    public string StateOrProvince {get; set;}

    public string Country {get; set;}

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public bool IsInUSA() => Country.Equals("USA", StringComparison.OrdinalIgnoreCase);

    public string GetFullAddress() => $"{StreetAddress}\n{City}, {StateOrProvince}\n{Country}";

}