using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        
        float ave = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {ave}");

        int largest = 0;
        foreach (int num in numbers)
        {
            if (num > largest)
                largest = num;
        }
        Console.WriteLine($"The largest number is: {largest}");
        
        int smallPos = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {smallPos}");
        
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}