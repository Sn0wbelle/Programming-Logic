using System;

public class Person
{
    public string SSN { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public Person()
    {
        SSN = "999999999";
        Name = "Unknown";
        Gender = "X";
        StreetAddress = "Unknown";
        City = "Unknown";
        State = "Unknown";
        ZipCode = "00000";
    }

    public Person(string ssn, string name, string gender, DateTime dob, string streetAddress, string city, string state, string zipCode)
    {
        SSN = ssn;
        Name = name;
        Gender = gender;
        DateOfBirth = dob;
        StreetAddress = streetAddress;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public virtual void Intro()
    {
        Console.WriteLine($"Hello, I am a person named {Name}");
        Console.WriteLine($"SSN={SSN}");
        Console.WriteLine($"Date Of Birth={DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Gender={Gender}");
        Console.WriteLine($"Address: {StreetAddress}, {City}, {State}, {ZipCode}");
    }
}
