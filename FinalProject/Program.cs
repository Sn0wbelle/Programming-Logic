using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Book and Author Demo");

        Person author1 = new Person("111111111", "Sarah Dessen", "F", Convert.ToDateTime("06/06/1970"));
        Person author2 = new Person("222222222", "Tomi Adeyemi", "F", Convert.ToDateTime("08/01/1993"));
        Person author3 = new Person("333333333", "Holly Black", "F", Convert.ToDateTime("11/10/1971"));
        Person author4 = new Person("444444444", "Sarah J. Maas", "F", Convert.ToDateTime("03/05/1986"));
        Person author5 = new Person("555555555", "Erin Morgenstern", "F", Convert.ToDateTime("07/08/1978"));
        Person author6 = new Person("666666666", "Leigh Bardugo", "F", Convert.ToDateTime("04/06/1975"));

        Book b1 = new Book("978-0670011103", "Lock and Key", author1, Convert.ToDateTime("04/22/2008"), "Viking Books for Young Readers");
        Book b2 = new Book("978-1250170972", "Children of Blood and Bone", author2, Convert.ToDateTime("03/06/2018"), "Henry Holt and Company");
        Book b3 = new Book("978-0316310277", "The Cruel Prince", author3, Convert.ToDateTime("01/02/2018"), "Little, Brown Books for Young Readers");
        Book b4 = new Book("978-1619634442", "A Court of Thorns and Roses", author4, Convert.ToDateTime("05/05/2015"), "Bloomsbury USA");
        Book b5 = new Book("978-0385534635", "The Night Circus", author5, Convert.ToDateTime("09/13/2011"), "Doubleday");
        Book b6 = new Book("978-1627792127", "Six of Crows", author6, Convert.ToDateTime("09/29/2015"), "Henry Holt and Company");

        author1.AddBook(b1);
        author2.AddBook(b2);
        author3.AddBook(b3);
        author4.AddBook(b4);
        author5.AddBook(b5);
        author6.AddBook(b6);

        Console.WriteLine("\nBooks by " + author1.Name + ":");
        author1.DisplayBooks();

        Console.WriteLine("\nBooks by " + author2.Name + ":");
        author2.DisplayBooks();

        Console.WriteLine("\nBooks by " + author3.Name + ":");
        author3.DisplayBooks();

        Console.WriteLine("\nBooks by " + author4.Name + ":");
        author4.DisplayBooks();

        Console.WriteLine("\nBooks by " + author5.Name + ":");
        author5.DisplayBooks();

        Console.WriteLine("\nBooks by " + author6.Name + ":");
        author6.DisplayBooks();

        author1.RemoveBook("978-0670011103");

        Console.WriteLine("\nAfter removing book from " + author1.Name + ":");
        author1.DisplayBooks();
    }
}

