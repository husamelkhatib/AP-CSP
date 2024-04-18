using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class prog505b {
  public string Name;
  public int[] scores = new int[5];

  public double Average() {
    int sum = 0;
    for (int i = 0; i < 5; i++) {
      sum += scores[i];
    }
    return (double)sum / 5;
  }

  public char Calculate(double average) {
    if (average >= 90) return 'A';
    if (average >= 80) return 'B';
    if (average >= 70) return 'C';
    if (average >= 60) return 'D';
    return 'F';
  }
}

public class Data {
  public static void Main(String[] args) {
    string dataFile = "prog505b.txt";
    List<prog505b> students = new List<prog505b>();
    string[] lines = File.ReadAllLines(dataFile);

    for (int i = 0; i < lines.Length; i += 2) {
    prog505b student = new prog505b();
      student.Name = lines[i];
      string[] scores = lines[i + 1].Split(' ');

      for (int j = 0; j < 5; j++) {
        student.scores[j] = int.Parse(scores[j]);
      }
      students.Add(student);
    }

    foreach (var student in students) {
      double average = student.Average();
      Console.WriteLine(student.Name + "  " + string.Join(" ", student.scores) + average + " " + student.Calculate(average));
    }

    for (int i = 0; i < 5; i++) {
      double total = 0;
      foreach (var student in students) {
        total += student.scores[i];
      }
      double average = total / students.Count;
      Console.WriteLine("Test: " + average);
    }
  }
}