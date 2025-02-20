using System;
using System.Linq;

class OddEven
{
    static void Main()
    {
        int[] OddNum = new int[10];
        int[] EvenNum = new int[10];
        int num = 0;
        int oddIndex = 0;
        int evenIndex = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                EvenNum[evenIndex++] = num;
            }
            else
            {
                OddNum[oddIndex++] = num;
            }
        }

        Array.Sort(OddNum, 0, oddIndex);
        Array.Sort(EvenNum, 0, evenIndex);
        Array.Reverse(EvenNum, 0, evenIndex);

        Console.WriteLine("\nOdd Numbers in Descending Order:");
        foreach (var odd in OddNum.Where(n => n != 0).OrderByDescending(n => n))
        {
            Console.WriteLine(odd);
        }

        Console.WriteLine("\nEven Numbers in Ascending Order:");
        foreach (var even in EvenNum.Where(n => n != 0).OrderBy(n => n))
        {
            Console.WriteLine(even);
        }

        int sumOdd = OddNum.Sum();
        int sumEven = EvenNum.Sum();

        Console.WriteLine($"\nSum of Odd Numbers = {sumOdd}");
        Console.WriteLine($"Sum of Even Numbers = {sumEven}");
    }
}

