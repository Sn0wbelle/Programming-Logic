using System;

class MiniExam
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter height in inches: ");
            double height = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter weight in pounds: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            
            double bmi = (703 * weight) / (height * height);
            Console.WriteLine($"{name}, your BMI is {bmi:F2}");
            
            if (bmi < 18.5)
                Console.WriteLine("You are Underweight");
            else if (bmi >= 18.5 && bmi <= 24.9)
                Console.WriteLine("You have Normal or Healthy Weight");
            else if (bmi >= 25.0 && bmi <= 29.9)
                Console.WriteLine("You are Overweight");
            else
                Console.WriteLine("You are Obese");
            
            Console.WriteLine();
        }
    }
}
