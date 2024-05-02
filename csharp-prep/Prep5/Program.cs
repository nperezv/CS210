using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string UserName = PromptUserName();
        int UserNumber = PrompUserNumber();
        int SquaredNumber = SquareNumber(UserNumber);

        DisplayResult(UserName, SquaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PrompUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the sqaure of your number is {square}");
    }
}
