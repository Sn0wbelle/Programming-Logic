using System;

public class Faculty : Person
{
    public string Id { get; set; }
    public string Title { get; set; }
    public DateTime DateOfEmployment { get; set; }
    public string Employer { get; set; }
    public decimal YearlySalary { get; set; }
    public bool Tenured { get; set; }

    public Faculty() : base()
    {
        Id = "Unknown";
        Title = "Instructor";
        Employer = "Unknown";
        DateOfEmployment = DateTime.MinValue;
        YearlySalary = 0;
        Tenured = false;
    }

    public Faculty(string ssn, string name, string gender, DateTime dob, string id, string employer, DateTime dateOfEmployment, decimal yearlySalary)
        : base(ssn, name, gender, dob)
    {
        Id = id;
        Employer = employer;
        DateOfEmployment = dateOfEmployment;
        YearlySalary = yearlySalary;
        Title = "Instructor";
    }

    public bool GrantTenure()
    {
        int yearsWorked = DateTime.Now.Year - DateOfEmployment.Year;
        Tenured = yearsWorked >= 5;
        return Tenured;
    }

    public bool Promote()
    {
        int yearsWorked = DateTime.Now.Year - DateOfEmployment.Year;

        if (Title == "Instructor" && yearsWorked > 2)
        {
            Title = "Assistant Professor";
            Console.WriteLine("Faculty promoted to Assistant Professor rank");
            return true;
        }
        else if (Title == "Assistant Professor" && yearsWorked > 5)
        {
            Title = "Associate Professor";
            Console.WriteLine("Faculty promoted to Associate Professor rank");
            return true;
        }
        else if (Title == "Associate Professor" && yearsWorked > 10)
        {
            Title = "Professor";
            Console.WriteLine("Faculty promoted to Professor rank");
            return true;
        }
        else if (Title == "Professor")
        {
            Console.WriteLine("No more promotion possible");
        }

        return false;
    }

    public override void Intro()
    {
        base.Intro();
        Console.WriteLine($"I work as {Title} at {Employer} since {DateOfEmployment.Year} and I am {(Tenured ? "tenured" : "not tenured")}");
    }
}
