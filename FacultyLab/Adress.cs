using System;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }

    // Default constructor
    public Address()
    {
        Street = "Unknown";
        City = "Unknown";
        State = "Unknown";
        PostalCode = "00000";
    }

    // Constructor with parameters
    public Address(string street, string city, string state, string postalCode)
    {
        Street = street;
        City = city;
        State = state;
        PostalCode = postalCode;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {PostalCode}";
    }
}
