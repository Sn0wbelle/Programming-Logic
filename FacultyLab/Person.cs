using System;

public class Person
{
    public string SSN { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person()
    {
        SSN = "999999999";
        Name = "Unknown";
        Address = "Unknown";
        Gender = "X";
        DateOfBirth = DateTime.MinValue;
    }

    public Person(string ssn, string name, string gender, DateTime dob)
    {
        SSN = ssn;
        Name = name;
        Address = "Unknown";
        Gender = gender;
        DateOfBirth = dob;
    }

    public virtual void Intro()
    {
        Console.WriteLine("Hello, I am a person named " + Name);
        Console.WriteLine("SSN=" + SSN);
        Console.WriteLine("Date Of Birth=" + DateOfBirth);
        Console.WriteLine("Gender=" + Gender);
        Console.WriteLine("Address=" + Address);
    }
}
