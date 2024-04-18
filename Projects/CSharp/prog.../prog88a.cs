using System;

class prog88a {
public static void Main (string[] args) {
    Console.WriteLine("Enter number 1-13: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number 2-20: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int sum = num1 + num2;
    int diff = num1 - num2;
    int mult = num1 * num2;
    int avg = sum / 2;
    int abs = Math.Abs(num1 - num2);
    int max = (num1 + num2 + Math.Abs(num1 - num2)) / 2;
    int min = (num1 + num2 - Math.Abs(num1 - num2)) / 2;
    Console.WriteLine("Original numbers are " + num1 + " and " + num2);
    Console.WriteLine("Sum = " + sum);
    Console.WriteLine("Difference = " + diff);
    Console.WriteLine("Product = " + mult);
    Console.WriteLine("Average = " + avg);
    Console.WriteLine("Absolute Value = " + abs);
    Console.WriteLine("The max is: " + max);
    Console.WriteLine("The min is: " + min);
  }
}