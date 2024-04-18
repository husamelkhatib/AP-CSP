using System;
using System.Collections.Generic;
using System.Linq;

class MSOE20154
{
    static void Main()
    {
        List<float> numbers = new List<float>();

        Console.WriteLine("Please enter 10 floating-point numbers:");

        for (int i = 0; i < 10; i++)
        {
            float num;
            Console.Write("Enter number " + (i + 1) + ": ");

            while (true)
            {
                string input = Console.ReadLine();
                if (float.TryParse(input, out num))
                {
                    break; 
                }
                Console.Write("Please enter a valid floating-point number: ");
            }

            numbers.Add(num);

            if (i >= 2) 
            {
                List<float> sortedNumbers = numbers.OrderByDescending(n => n).ToList();

                if (sortedNumbers.Count >= 3)
                {
                    Console.WriteLine("The third largest number so far is: " + sortedNumbers[2]);
                }
                else
                {

                    Console.WriteLine("The third largest number so far is: " + sortedNumbers.Last());
                }
            }
        }
    }
}
