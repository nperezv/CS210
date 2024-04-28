using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please type your grade percentage: ");
        string UserInput = Console.ReadLine();
        int percentage = int.Parse(UserInput);

        string grade = "";

        if(percentage >= 90)
        {
            grade = "A";
        }

        else if(percentage >= 80)
        {
            grade = "B";
        }

        else if(percentage >= 70)
        {
            grade = "C";
        }

        else if(percentage >= 60)
        {
            grade = "D";
        }

        else
        {
            grade = "F";
        }
        
        Console.WriteLine($"Your final grade is: {grade}");

        if(percentage >= 75)
        {
            Console.WriteLine("Passed!");
        }

        else
        {
            Console.WriteLine("Keep working hard. Try again!");
        }
    }
}
