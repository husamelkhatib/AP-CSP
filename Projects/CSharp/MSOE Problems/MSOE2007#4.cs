using System;

class MSOE2007Q4
{
  public static void Main(string[] args)
  {
      Console.WriteLine("Enter first address (e.g., 100 N 25 E): ");
      string firstAddress = Console.ReadLine();
      Console.WriteLine("Enter second address (e.g., 310 N 445 W): ");
      string secondAddress = Console.ReadLine();

      var firstCoords = AddressToCoords(firstAddress);
      var secondCoords = AddressToCoords(secondAddress);

      double distance = CalculateDistance(firstCoords, secondCoords);

      Console.WriteLine("Distance: " + distance + " miles");
  }

  static (double, double) AddressToCoords(string address)
  {
      string[] parts = address.Split(' ');
      double northSouth = double.Parse(parts[0]);
      double eastWest = double.Parse(parts[2]);

      if (parts[1].ToUpper() == "S") northSouth = -northSouth;
      if (parts[3].ToUpper() == "W") eastWest = -eastWest;

      double x = eastWest / 1200;
      double y = northSouth / 800;

      return (x, y);
  }

  static double CalculateDistance((double x, double y) point1, (double x, double y) point2)
  {
      return Math.Sqrt(Math.Pow(point1.x - point2.x, 2) + Math.Pow(point1.y - point2.y, 2));
  }
}


