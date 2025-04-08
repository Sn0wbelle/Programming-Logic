using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Faculty Example:");

        Faculty f1 = new Faculty("John", "Doe", "123 Main St", "Cleveland", "OH", "44101");
        f1.DateOfEmployment = new DateTime(2010, 8, 15);
        f1.Employer = "Tri-C";
        f1.YearlySalary = 55000.00m;

        f1.Intro();

        f1.GrantTenure();
        f1.Promote();

        f1.Intro();

        Student s1 = new Student("123-45-6789", "Jane Smith", "F", new DateTime(2000, 6, 20), "S9876", "Tri-C", 3.8, "456 Elm St", "Cleveland", "OH", "44101");

        s1.Intro();
    }
}
