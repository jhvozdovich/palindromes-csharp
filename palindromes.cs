using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void ReverseInput(char[] letters)
  {
    char[] lettersClone = letters.Clone() as char[];
    Array.Reverse(lettersClone);
    Console.WriteLine(lettersClone);
    if (Enumerable.SequenceEqual(letters, lettersClone))
    {
      Console.WriteLine("Palindromy! ");
    }
    else
    {
      Console.WriteLine("Sadly not palindromy :(");
    }
  }
  
  public static void Main()
  {
    Console.WriteLine("Enter a word to assess its palindrominess: ");
    string userEntry = Console.ReadLine();
    char[] letters = userEntry.ToCharArray();
    foreach (char letter in letters)
    {
      Console.WriteLine(letter + " ");
    }
    ReverseInput(letters);
  }
}