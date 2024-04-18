using System;

class stringInterviewQuestion12 {
public static void Main (string[] args) {
  Console.WriteLine("Enter a sentence:");
  string inputSentence = Console.ReadLine();
  string reversedSentence = reverseWords(inputSentence);


}

  static string reverseWords(string sentence) {
    string[] words = sentence.Split(' ');
    string[] reversedWords = new string[words.Length];

    for (int i = 0; i < words.Length; i++) {
      reversedWords[i] = words[words.Length - 1 - i];
    }
    string reversedSentence = string.Join(" ", reversedWords);
    Console.WriteLine("ReversedSentence:");
  Console.WriteLine(reversedSentence);
    return reversedSentence;

  }

  }