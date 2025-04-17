using System;

public class Employee
{
    private string firstname;
    private string lastname;
    private string id;
    private int age;
    private double yearlysalary;
    private string employmentstatus;

    public Employee()
    {
        firstname = "Unknown";
        lastname = "Unknown";
        id = "Unknown";
        age = 0;
        employmentstatus = "active";
    }

    public Employee(string e_fname, string e_lname, string e_id, int e_age)
    {
        firstname = e_fname;
        lastname = e_lname;
        id = e_id;
        age = e_age;
        employmentstatus = "active";
    }

    public void Intro()
    {
        Console.WriteLine("Employee Information:");
        Console.WriteLine("First Name: " + firstname);
        Console.WriteLine("Last Name: " + lastname);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Employment Status: " + employmentstatus);
        Console.WriteLine();
    }
}
