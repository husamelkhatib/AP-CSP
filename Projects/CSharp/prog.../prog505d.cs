using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class prog505d {
  public string FName { get; set; }
  public string LName { get; set; }
  public int[] hits { get; set; }
  public int[] bats { get; set; }

  public prog505d() {
    hits = new int[7];
    bats = new int[7];
  }
}

public class MathShit {
  public static void Main(String[] args) {
    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    List<prog505d> players = new List<prog505d>();

    foreach (string line in File.ReadLines("prog505d.txt")) {
      string[] parts = line.Split(' ');
      prog505d p = new prog505d {
        FName = parts[0],
        LName = parts[1]
      };

      for (int i = 0; i < 7; i++) {
        p.hits[i] = int.Parse(parts[2 + i * 2]);
        p.bats[i] = int.Parse(parts[3 + i * 2]);
      }

      players.Add(p);
    }

    foreach (prog505d p in players) {
      Console.Write(p.FName + " " + p.LName + " ");

      for (int i = 0; i < 7; i++) {
        if (p.bats[i] == 0)
        Console.Write(".000 ");
        else
        Console.Write((double)p.hits[i] / p.bats[i] + " ");
      }
      Console.WriteLine();
    }

    Console.WriteLine();

    int[] totalHits = new int[7];
    int[] totalBats = new int[7];
    foreach (prog505d p in players) {
      for (int i = 0; i < 7; i++) {
        totalHits[i] += p.hits[i];
        totalBats[i] += p.bats[i];
      }
    }

    int totalTotalHits = 0;
    for (int i = 0; i < 7; i++) {
      double teamAverage = (double)totalHits[i] / totalBats[i];
      Console.WriteLine(days[i] + " " + totalHits[i] + " " + teamAverage);
      totalTotalHits += totalHits[i];
    }
    Console.WriteLine("Total Hits " + totalTotalHits);

  }
}