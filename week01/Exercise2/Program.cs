using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("your grade in percent % : ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        bool aproove = false;
        string letter;

        if (grade > 90 || grade == 90)
        {
            letter = "A";
            aproove = true;
        }
        else if (grade > 80 || grade == 80)
        {
            letter = "B";
            aproove = true;
        }
        else if (grade > 70 || grade == 70)
        {
            letter = "C";
            aproove = true;
        }
        else if (grade > 60 || grade == 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"your grade is {letter}");
        
        if (aproove == true)
        {
            Console.WriteLine("Congratulations, you passed the grade!");
        }
        else if (aproove == false)
        {
            Console.WriteLine("sorry, you lose the grade, try it harder next time!");
        }
    }
}