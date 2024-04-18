using System;
using System.Collections.Generic;

class MSOE2007Q5
{
    static void Main()
    {
        string input = "TTHTHTTTTHHHTHTTTTH";
        FindMaxRepetitions(input);
    }

    static void FindMaxRepetitions(string input)
    {
        int maxLength = 0;
        List<char> maxRepeatingChars = new List<char>();
        int currentLength = 1;

        for (int i = 1; i <= input.Length; i++)
        {
            if (i < input.Length && input[i] == input[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxRepeatingChars.Clear();
                    maxRepeatingChars.Add(input[i - 1]);
                }
                else if (currentLength == maxLength)
                {
                    maxRepeatingChars.Add(input[i - 1]);
                }
                currentLength = 1; 
        }

        Console.WriteLine("Maximum repetition length: " + maxLength);
        Console.WriteLine("Characters with maximum repetition: " + String.Join(", ", maxRepeatingChars));
    }
}
  }
