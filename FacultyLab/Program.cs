using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inheritance Example:");

        Person p1 = new Person("111-22-3333", "John Doe", "M", new DateTime(1980, 5, 15));
        p1.Intro();

        Console.WriteLine();

        Student s1 = new Student("222-33-4444", "Alice Smith", "F", new DateTime(2000, 8, 21), "S1234", "Tri-C", 3.8);
        s1.Intro();

        Console.WriteLine();

        Faculty f1 = new Faculty("333-44-5555", "Dr. Smith", "M", new DateTime(1975, 3, 10), "F1234", "Tri-C", new DateTime(2010, 8, 15), 75000);
        f1.Intro();

        Console.WriteLine();
        
        f1.GrantTenure();
        f1.Promote();
    }
}
