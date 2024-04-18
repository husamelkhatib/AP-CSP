using System;

class prog54b {
  public static void Main (string[] args) {

        Console.WriteLine("Enter your first 3 digit number");
    int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your second 3 digit number");
    int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your third 3 digit number");
    int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your fourth 3 digit number");
    int num4 = Convert.ToInt32(Console.ReadLine());

    int total = num1 + num2 + num3 + num4;

    double average = (double)total/4;
    Console.WriteLine("The total of all four numbers is: " + (double)total); 
    Console.WriteLine("The average of all of the numbers is: " + average);

  }
}