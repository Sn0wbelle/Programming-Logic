using System;

class CommissionLab
{
    static void Main()
    {
        // Get input from user
        Console.Write("Enter name of salesperson: ");
        string name = Console.ReadLine() ?? "Unknown"; 

        Console.Write("Enter sales amount: ");
        double salesAmount;
        
        // Ensure valid input for sales amount
        while (!double.TryParse(Console.ReadLine(), out salesAmount) || salesAmount < 0)
        {
            Console.Write("Invalid input. Please enter a valid sales amount: ");
        }

        // Calculate commission
        double commission = 200 + (0.09 * salesAmount);

        // Determine performance status
        string performanceStatus;
        if (salesAmount >= 15000)
            performanceStatus = "Outstanding";
        else if (salesAmount >= 10000)
            performanceStatus = "Excellent";
        else if (salesAmount >= 5000)
            performanceStatus = "Good";
        else if (salesAmount >= 3000)
            performanceStatus = "Average";
        else
            performanceStatus = "Poor";

        // Display results
        Console.WriteLine("\n--- Commission Report ---");
        Console.WriteLine($"Name of Sales Person: {name}");
        Console.WriteLine($"Total Sales Amount: ${salesAmount}");
        Console.WriteLine($"Commission: ${commission}");
        Console.WriteLine($"Performance Status: {performanceStatus}");
    }
}
