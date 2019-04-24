using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Program
  {

     public static void Main()
     {
        Console.WriteLine("Enter a word to check for anagrams of: ");
        string checkAgainst = Console.ReadLine();
        int x = 0;
        for (int i = 0; x == 0; i++)
        {
          Console.WriteLine("Enter a word to see if it is an anagram of " + checkAgainst + ":");
          Word toCheck = new Word(Console.ReadLine());
          Console.WriteLine("Add more words? (Y/N)");
          string userInput = Console.ReadLine().ToUpper();
          if(userInput == "N")
          {
            x = 1;
          }
        }

      foreach (Word word in Word.GetAll())
       {
         if(Word.IsAnagram(word.GetWord(),checkAgainst) == true)
         {
           Console.WriteLine(word.GetWord() + " is an anagram of " + checkAgainst);
          } else
          {
           Console.WriteLine(word.GetWord() + " is not an anagram of " + checkAgainst);
          }
        }
     }
  }
}
