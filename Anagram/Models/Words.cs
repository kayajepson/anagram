using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Word
  {
    private string _word;
    private static List<Word> _instances = new List<Word> {};

    public Word (string word)
    {
      _word = word;
      _instances.Add(this);
    }

    public string GetWord()
    {
      return _word;
    }


    public static List<Word> GetAll()
    {
     return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static bool IsAnagram(string word, string check)
    {
      char[] wordArray = word.ToCharArray();
      Array.Sort(wordArray);
      string wordString = new String(wordArray);
      char[] checkArray = check.ToCharArray();
      Array.Sort(checkArray);
      string checkString = new String(checkArray);

      if (wordString == checkString) {
        return true;
      } else
      {
        return false;
      }
    }
  }
}
