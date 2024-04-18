using System;

class MSOE20187
{
    static void Main()
    {
        Console.Write("Enter UNIX time: ");
        long unixTime = Convert.ToInt64(Console.ReadLine());

        DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        DateTime localDate = epoch.AddSeconds(unixTime).ToLocalTime();

        Console.WriteLine(localDate.ToString("hh:mm tt  MM/dd/yyyy"));
    }
}
