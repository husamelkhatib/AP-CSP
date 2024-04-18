using System;

class MSOE2010Q6
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of vertices in the polygon: ");
        int n = int.Parse(Console.ReadLine());
        double[] x = new double[n];
        double[] y = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter x-coordinate of vertex " + i + ": ");
            x[i] = double.Parse(Console.ReadLine());

            Console.Write("Enter y-coordinate of vertex " + i + ": ");
            y[i] = double.Parse(Console.ReadLine());
        }

        double area = CalculateArea(x, y, n);
        Console.WriteLine("The area of the polygon is: " + area);
    }

    private static double CalculateArea(double[] x, double[] y, int n)
    {
        double sum = 0;
        for (int i = 0; i < n - 1; i++)
        {
            sum += x[i] * y[i + 1] - y[i] * x[i + 1];
        }

        sum += x[n - 1] * y[0] - y[n - 1] * x[0];
        return Math.Abs(sum) / 2;
    }
}
