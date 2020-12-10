using System;
using System.Collections.Generic;
using Scrabble;

namespace Check.Score
{

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Enter in a word to check its Scrabble score!");
      string response = Console.ReadLine().ToLower();

      Console.WriteLine(response);
    }
  }
}