using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        DisplayWelcome();


        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        string fullname = PromptUserName();


        static float PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            float number = float.Parse(input);
            return number;
        }
        float number = PromptUserNumber();


        static float SquareNumber(float number)
        {
            float squared = number * number;
            return squared;
        }
        float squarednumber = SquareNumber(number);


        static void DisplayResult(string fullname, float squarednumber)
        {
            Console.WriteLine($"{fullname}, the square of your number is {squarednumber}");
        }
        DisplayResult(fullname, squarednumber);
    }   
}