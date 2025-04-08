using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    
   public string Id {get; set;}
   public string Firstname {get; set;}
   public string Lastname {get; set;}
   public string Address {get; set;}
   public string Title {get; set;}
    DateTime JoiningDate {get; set;}
    bool IsActive{ get; set;}
    
    public Employee()
    {
        IsActive = true;
    }
    
    public Employee(string id, string fname, string lname, string title)
    {
        Id = id;
        Firstname = fname;
        Lastname = lname;
        Title = title;
        IsActive = true;
    }
    
    public void Intro()
    {
        Console.WriteLine("Employee first name: {0} last name: {1} title: {2} currentStatus : {3}", Firstname, Lastname, Title, IsActive);
    }
    
    
    
}