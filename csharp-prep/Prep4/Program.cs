using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Create the list and variable
        int number = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //Generate the Lopp til get 0
        while(number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if(number != 0)
            {
                numbers.Add(number);
            }
        }
        // Compute the sum, or total, of the numbers in the list.
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list.   
        double avg = numbers.Average();
        Console.WriteLine($"The average is: {avg}");

        // Find the maximum, or largest, number in the list.
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

    }
}