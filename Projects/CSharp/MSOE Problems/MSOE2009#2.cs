using System;

class MSOE2009Q2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter current latitude (in degrees):");
        double lat1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter current longitude (in degrees):");
        double lon1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter car's latitude (in degrees):");
        double lat2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter car's longitude (in degrees):");
        double lon2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateDistance(lat1, lon1, lat2, lon2);
        Console.WriteLine($"The approximate walking distance to your car is: {distance} miles");
    }

    static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
    {
        double r = 3963.1; 
        double radianFactor = Math.PI / 180;

        lat1 *= radianFactor;
        lon1 *= radianFactor;
        lat2 *= radianFactor;
        lon2 *= radianFactor;

        double distance = r * Math.Acos(
            Math.Cos(lat1) * Math.Cos(lat2) * Math.Cos(lon2 - lon1) +
            Math.Sin(lat1) * Math.Sin(lat2)
        );

        return distance;
    }
}
