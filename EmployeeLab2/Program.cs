using System;

class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        e1.Intro(); 

        Employee e2 = new Employee("Robert", "Downey", "12321", 12);
        e2.YearlySalary = 100;  
        e2.Intro();  

        Employee e3 = new Employee("John", "Smith", "S0089", 38);
        e3.YearlySalary = 50000;  
        e3.Intro(); 

        e3.IncreaseSalary(-2);  
        e3.RemoveEmployee();  
        e3.Intro();  

        Employee e4 = new Employee("Maria", "Lambert", "S0100", 26);
        e4.YearlySalary = 80000;
        
        e4.IncreaseSalary(7);  
        e4.Intro();  
        
        e4.RemoveEmployee();  
        e4.Intro();  
        e4.RemoveEmployee();  
    }
}


