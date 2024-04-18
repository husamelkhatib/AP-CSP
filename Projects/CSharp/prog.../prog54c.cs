using System;

class prog54c {
public static void Main (string[] args) {

    double pi = 3.14159;

    Console.WriteLine("Enter the radius");
    double rad = Convert.ToDouble(Console.ReadLine());
    double area = pi * rad * rad;
    double circ = 2 * pi * rad;
    double roundedrad = Math.Round(rad, 3);
       double roundedarea = Math.Round(area, 3);
       double roundedcirc = Math.Round(circ, 3);
    Console.WriteLine("The radius is: " + roundedrad);
    Console.WriteLine("The area is: " + roundedarea);
    Console.WriteLine("The circumference is: " + roundedcirc);
  }
  }