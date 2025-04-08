class Program
{
    static void Main()
    {
        // Create 6 employees
        Employee e1 = new Employee("101", "Alice", "Johnson", "Developer");
        Employee e2 = new Employee("102", "Bob", "Smith", "HR Rep");
        Employee e3 = new Employee("103", "Charlie", "Brown", "Analyst");
        Employee e4 = new Employee("104", "Diana", "Prince", "Marketing");
        Employee e5 = new Employee("105", "Evan", "Davis", "Engineer");
        Employee e6 = new Employee("106", "Fiona", "Green", "SalesRep");

        // Create 2 Employee Managers
        EmployeeManager em1 = new EmployeeManager();
        EmployeeManager em2 = new EmployeeManager();

        // Employee Manager #1 Operations
        Console.WriteLine("\n--- Employee Manager #1 ---");
        em1.AddEmployee(e1);
        em1.AddEmployee(e2);
        em1.AddEmployee(e3);

        Console.WriteLine("\nDisplaying Employees for Manager 1:");
        em1.DisplayEmployees();

        Console.WriteLine("\nUpdating employee with ID 102:");
        em1.UpdateEmployee("102", "HR Rep2");

        Console.WriteLine("\nRemoving employee with ID 101:");
        em1.RemoveEmployee("101");

        Console.WriteLine("\nDisplaying Employees for Manager 1 After Changes:");
        em1.DisplayEmployees();

        // Employee Manager #2 Operations
        Console.WriteLine("\n--- Employee Manager #2 ---");
        em2.AddEmployee(e4);
        em2.AddEmployee(e5);
        em2.AddEmployee(e6);

        Console.WriteLine("\nDisplaying Employees for Manager 2:");
        em2.DisplayEmployees();

        Console.WriteLine("\nUpdating employee with ID 105:");
        em2.UpdateEmployee("105", "HR Rep2");

        Console.WriteLine("\nRemoving employee with ID 106:");
        em2.RemoveEmployee("106");

        Console.WriteLine("\nDisplaying Employees for Manager 2 After Changes:");
        em2.DisplayEmployees();
    }
}
