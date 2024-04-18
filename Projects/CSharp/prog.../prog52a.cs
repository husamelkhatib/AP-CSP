using System;

class prog52a {
  public static void Main (string[] args) {
    Console.WriteLine("What is the length?");

    int length = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("What is the width?");
    int width = Convert.ToInt32(Console.ReadLine());
    int area = length * width;
    int perim = 2 * (length + width);
    Console.WriteLine("Length: " + length);
    Console.WriteLine("Width: " + width);
    Console.WriteLine("Area: " + area);
    Console.WriteLine("Perimeter: " + perim);
  }
}