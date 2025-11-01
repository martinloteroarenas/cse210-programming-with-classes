using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        bool guessed = false;
        do
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.Write("You guess it!");
                guessed = true;
            }
        } while (guessed == false); 
    }
}