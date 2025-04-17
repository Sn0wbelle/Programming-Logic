using System;
using System.Collections.Generic;

class EmployeeManager
{
    public List<Employee> DirectReportList { get; set; }
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Title { get; set; }

    public EmployeeManager()
    {
        DirectReportList = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        DirectReportList.Add(employee);
        Console.WriteLine($"Success: Added {employee.Firstname} {employee.Lastname} to the employee list.");
    }

    public void DisplayEmployees()
    {
        if (DirectReportList.Count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        Console.WriteLine("ID\tFirst Name\tLast Name\tTitle");
        foreach (var emp in DirectReportList)
        {
            Console.WriteLine($"{emp.Id}\t{emp.Firstname}\t\t{emp.Lastname}\t\t{emp.Title}");
        }
    }

    public Employee SearchEmployee(string id)
    {
        return DirectReportList.Find(e => e.Id == id);
    }

    public bool UpdateEmployee(string id, string newTitle)
    {
        var emp = SearchEmployee(id);
        if (emp != null)
        {
            emp.Title = newTitle;
            Console.WriteLine($"Updated {emp.Firstname}'s title to {newTitle}");
            return true;
        }
        return false;
    }

    public bool RemoveEmployee(string id)
    {
        var emp = SearchEmployee(id);
        if (emp != null)
        {
            DirectReportList.Remove(emp);
            Console.WriteLine($"Removed employee {emp.Firstname} {emp.Lastname}");
            return true;
        }
        return false;
    }
}
