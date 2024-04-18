using System;
using System.Collections.Generic;

public class CreateTask {
  public static void Main(string[] args) {
    Console.WriteLine("Enter song lyrics: ");
    string lyrics = Console.ReadLine();

    lyrics = lyrics.ToLower();

    Dictionary<string, int> wordCounts = new Dictionary<string, int>();

    string[] words = lyrics.Split(new char[] {' ', '\n', '\r', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

    foreach (string word in words) {
      if (wordCounts.ContainsKey(word)) {
        wordCounts[word]++;
      } else {
        wordCounts.Add(word, 1);
      }
    }
    foreach (KeyValuePair<string, int> pair in wordCounts) {
      Console.WriteLine("Word: " + pair.Key + " Count: " + pair.Value);
    }
  }
}