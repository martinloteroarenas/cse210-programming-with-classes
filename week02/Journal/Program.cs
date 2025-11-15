using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        string answer = "0";
        while (answer != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                PromptGenerator RandomPrompt = new PromptGenerator();
                string prompt = RandomPrompt.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                string promptAnswer = Console.ReadLine();


                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = promptAnswer;
            }
        }
    }
}