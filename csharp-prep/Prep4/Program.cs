using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1; 

        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            
            numbers.Add(number);   
        }

        int list_total = numbers.Sum();
        int list_avg = list_total / numbers.Count;
        int max = numbers.Max();
        int min = numbers.Min();
        
        Console.WriteLine($"The sum is: {list_total}");
        Console.WriteLine($"The average is: {list_avg}");
        Console.WriteLine($"The maximumn value is {max}");
        Console.WriteLine($"The minimumn value is {min}");


         
    }
}