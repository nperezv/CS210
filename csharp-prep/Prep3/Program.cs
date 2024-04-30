using System;

class Program
{
    static void Main(string[] args)
    {
        // Magic Number provided by User input
        // Console.Write("Please type a number to set the Magic Number: ");
        // int MagicNumber = int.Parse(Console.ReadLine());
        
        // Random Magin Number configured
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != MagicNumber)
        {
            Console.Write("Please type your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (MagicNumber > guess)
            {
                Console.WriteLine("Get higher");
            }
            else if (MagicNumber < guess)
            {
                Console.WriteLine("Get lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}
