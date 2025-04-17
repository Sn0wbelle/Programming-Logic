using System;

public class Person
{
    private string ssn;
    public string SSN
    {
        get { return ssn; }
        set
        {
            if (value.Length == 9)
                ssn = value;
            else
                Console.WriteLine("Invalid ssn. Length not equal to 9");
        }
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    private List<Book> Books = new List<Book>();

    public Person()
    {
        SSN = "999999999";
        Name = "Unknown";
        Address = "Unknown";
        Gender = "X";
    }

    public Person(string ssn, string name, string gender, DateTime dob)
    {
        SSN = ssn;
        Name = name;
        Address = "Unknown";
        Gender = gender;
        DateOfBirth = dob;
    }

    public virtual void Intro()
    {
        Console.WriteLine("Hello I am a person named " + Name);
        Console.WriteLine("SSN=" + SSN);
        Console.WriteLine("Date Of Birth=" + DateOfBirth.ToShortDateString());
        Console.WriteLine("Gender=" + Gender);
        Console.WriteLine("Address=" + Address);
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
    }

    public void AddBook(Book b)
    {
        Books.Add(b);
    }

    public void RemoveBook(string isbn)
    {
        Book toRemove = Books.Find(b => b.ISBN == isbn);
        if (toRemove != null)
            Books.Remove(toRemove);
    }

    public void DisplayBooks()
    {
        foreach (Book b in Books)
            b.Display();
    }
}
