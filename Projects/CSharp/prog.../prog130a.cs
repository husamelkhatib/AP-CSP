using System;

class prog130a {
  public static void Main (String[] args) {
    Console.WriteLine("Enter a number: ");
    int n = int.Parse(Console.ReadLine());
    int steps = 0;
    while (n != 1) {
     if (n % 2 != 0) {
       Console.Write(n + " is odd, so I make 3n+1: ");
       n = n * 3 + 1;
       Console.WriteLine(n);
     } else {
       Console.Write(n + "is even, so I take half: ");
       n = n/2;
       Console.WriteLine(n);
       }
      steps++;
     }
    Console.WriteLine("The process took " + steps + " steps to reach 1");
  }
}