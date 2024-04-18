using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class prog505a {
  public String Name { get; set; }
  public int BooksRead { get; set; }
  public int points { get; set; }

  public prog505a(String name, int booksRead)  {
    Name = name;
    BooksRead = booksRead;
    points = Calculate(booksRead);
  }

  private int Calculate(int booksRead) {
  if (booksRead == 7) return 95;
    if (booksRead <= 3) return booksRead * 10;
  if (booksRead <= 6) return 30 + ((booksRead - 3) * 15);
    return 30 + 45 + ((booksRead - 6) * 20);
    }

  public static void Main(String[] args) {
    List<prog505a> contestants = new List<prog505a>();
    using (StreamReader sr = new StreamReader("prog505a.txt")) {
      while (!sr.EndOfStream) {
        var name = sr.ReadLine();
        var booksRead = int.Parse(sr.ReadLine());
        contestants.Add(new prog505a(name, booksRead));
      }
    }

    int totalPoints = 0;
    prog505a winner = contestants[0];

    foreach (var contestant in contestants) {
      totalPoints += contestant.points;
      if (contestant.points > winner.points) {
        winner = contestant;
      }
      Console.WriteLine(contestant.Name + " " + contestant.BooksRead + " " + contestant.points);
    }
    double avg = totalPoints / (double)contestants.Count;
    Console.WriteLine("Average points " + avg);
    Console.WriteLine("The winner of the contest is: " + winner.Name);
  }
}