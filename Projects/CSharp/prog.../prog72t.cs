using System;

class prog72t {
public static void Main (string[] args) {
  Console.WriteLine("Enter the first time: ");
  int first = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter the second time: ");
  int second = Convert.ToInt32(Console.ReadLine());

  if (first > second) {
    second += 2400;
  }
  int hours = (second - first) / 100;
  int minutes = (second - first) % 100;

  Console.WriteLine("hours: " + hours);
  Console.WriteLine("minutes: " + minutes);
  }
  }