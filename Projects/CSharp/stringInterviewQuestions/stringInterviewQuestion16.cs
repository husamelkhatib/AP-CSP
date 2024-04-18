using System;
class stringInterviewQuestion16 {
  public static void Main (String[] args) {
    Console.WriteLine("Enter the first string");
    string firstString = Console.ReadLine();
    Console.WriteLine("Enter the second string");
    string secondString = Console.ReadLine();
    int index = firstString.IndexOf(secondString);
    if (index != 1) {
      Console.WriteLine("The second string is contained withing the first string at index " + index);
    } else {
      Console.WriteLine("The second string is not contained within the first string");
    }
    }
  }