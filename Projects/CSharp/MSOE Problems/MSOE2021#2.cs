using System;

class MSOE20212
{
    static void Main(string[] args)
    {
        Console.Write("Enter the initial water capacity (in ounces): ");
        int capacity = int.Parse(Console.ReadLine());

        Console.Write("Enter the sequence of cup sizes (4, 6, or 8 ounces only, no spaces): ");
        string cupsSequence = Console.ReadLine();

        int cupsMade = 0;

        foreach (char cup in cupsSequence)
        {
            int cupSize = int.Parse(cup.ToString());
            int waterNeeded = cupSize + 1; 

            if (capacity >= waterNeeded)
            {
                capacity -= waterNeeded;
                cupsMade++; 
            }
            else
            {
                break;
            }

            if (capacity < 10)
            {
                break; 
            }
        }

        Console.WriteLine("Filled " + cupsMade + "cups.");
    }
}
