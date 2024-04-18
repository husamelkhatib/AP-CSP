using System;

class prog58h {
public static void Main (string[] args) {
  Console.Write("Amount Saved: ");
  double amountSaved = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Interest rate: ");
  double interestRate = Convert.ToDouble(Console.ReadLine());
  Console.Write("Number of times compounded per year: ");
  int compoundedPerYear = Convert.ToInt32(Console.ReadLine());
  Console.Write("Number of days at interest: ");
  int daysAtInterest = Convert.ToInt32(Console.ReadLine());

  double Decimal = interestRate / 100.0;
  double interest = amountSaved * Math.Pow(1 + (Decimal / compoundedPerYear), compoundedPerYear * (daysAtInterest / 365.0)) - amountSaved;

  double totalAmount = amountSaved + interest;

  double roundedInterest = Math.Round(interest, 2);
  double roundedTotalAmount = Math.Round(totalAmount, 2);
  Console.WriteLine("The interest earned is: " + roundedInterest);
  Console.WriteLine("The total amount in savings now is: " + roundedTotalAmount);
  }
  }