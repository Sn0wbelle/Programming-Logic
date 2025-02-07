using System;

class SpeedLab
{
    static void Main()
    {
        // Ask the user how many cars they want to calculate speed for
        Console.Write("Enter the number of cars: ");
        int numCars;
        
        // Validate input for numCars
        while (!int.TryParse(Console.ReadLine(), out numCars) || numCars <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
        }

        double totalSpeed = 0; // To accumulate total speed

        // Loop to get input and calculate speed for each car
        for (int i = 1; i <= numCars; i++)
        {
            Console.Write($"\nCar {i} - Enter distance traveled (in miles): ");
            double distance;
            
            // Validate input for distance
            while (!double.TryParse(Console.ReadLine(), out distance) || distance < 0)
            {
                Console.Write("Invalid input. Please enter a positive number: ");
            }

            Console.Write($"Car {i} - Enter time taken (in hours): ");
            int time;

            // Validate input for time
            while (!int.TryParse(Console.ReadLine(), out time) || time <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
            }

            // Calculate speed
            double speed = distance / time;
            totalSpeed += speed;

            // Display speed for the car
            Console.WriteLine($"Car {i} - Speed: {speed:F2} mph");
        }

        // Calculate and display average speed
        double averageSpeed = totalSpeed / numCars;
        Console.WriteLine($"\nThe average speed of the cars is: {averageSpeed:F2} mph");
    }
}
