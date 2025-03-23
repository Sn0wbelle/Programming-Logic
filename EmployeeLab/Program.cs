using System;

class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        e1.Intro();

        Employee e2 = new Employee("John", "Smith", "1234", 45);
        e2.Intro();
    }
}

