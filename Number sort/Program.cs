using System;
using System.Collections.Generic;
using System.Linq;

namespace Number_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { };

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please type in a number: "); 
                var input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);

                if (numbers.Count != numbers.Distinct().Count())
                {
                    Console.WriteLine("You have failed to type 5 unique numbers.");
                    break;
                }
            }
            if (numbers.Count == numbers.Distinct().Count())
            {
                numbers.Sort();
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
