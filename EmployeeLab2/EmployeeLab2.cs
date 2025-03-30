using System;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Id { get; set; }
    public string EmploymentStatus { get; private set; } = "active"; 

    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 18)
                age = value;
            else
            {
                Console.WriteLine($"Error: Age cannot be less than 18.");
                age = value;
                EmploymentStatus = "inactive";
            }
        }
    }

    private double yearlySalary;
    public double YearlySalary
    {
        get { return yearlySalary; }
        set
        {
            if (value >= 1000)
                yearlySalary = value;
            else
            {
                Console.WriteLine($"Error: YearlySalary cannot be less than $1000.");
                yearlySalary = value;
                EmploymentStatus = "inactive";
            }
        }
    }

    public Employee()
    {
        FirstName = "Unknown";
        LastName = "Unknown";
        Id = "Unknown";
        Age = 0;
        EmploymentStatus = "active";
    }

    public Employee(string firstName, string lastName, string id, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        Age = age;
        EmploymentStatus = "active";
    }

    public void Intro()
    {
        Console.WriteLine("\nEmployee Information:");
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Yearly Salary: ${YearlySalary}");
        Console.WriteLine($"Employment Status: {EmploymentStatus}\n");
    }

    public void IncreaseSalary(double percent)
    {
        if (percent >= 0)
        {
            Console.WriteLine("Percentage is valid.");
            YearlySalary = YearlySalary + (YearlySalary * (percent / 100));
        }
        else
        {
            Console.WriteLine("Error: Percentage is invalid.");
            return;
        }
    }

    public void RemoveEmployee()
    {
        if (EmploymentStatus == "inactive")
        {
            Console.WriteLine("Employee already inactive.");
        }
        else
        {
            EmploymentStatus = "inactive";
            Console.WriteLine("Employee removed.");
        }
    }
}
