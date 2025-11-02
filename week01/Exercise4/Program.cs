using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<float> numbers;
        numbers = new List<float>();
        float number = 1;
        float largest = 0;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = float.Parse(input);
            if(number != 0)
            {
                numbers.Add(number);   
            }
        }
        float sum = 0;
        foreach (int numberList in numbers)
        {
            sum = sum + numberList;
            if (numberList>largest)
            {
                largest = numberList;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The Average is: {average}");

        Console.WriteLine($"The largest number is: {largest}");       
    }
}