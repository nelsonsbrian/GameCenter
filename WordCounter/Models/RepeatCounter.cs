using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

  public class RepeatCounter
  {
    public static string MasterString;
    public static List<RepeatCounter> InputWords = new List<RepeatCounter>() {};

    public RepeatCounter(string input)
    {
      Input = input;
      InputWords.Add(this);
    }

    public string Input { get; set; }

    //used for testing the entire list of words
    public static int[] WordCount()
    {
      int[] countArr = new int[InputWords.Count];
      int i = 0;
      foreach (RepeatCounter word in InputWords) {
        countArr[i] = word.RepeatCount();
        i++;
      }
      return countArr;
    }

    //checks a single word for repeats against master word
    public int RepeatCount()
    {
      int count = 0;
      int i = 0;
      while ((i = MasterString.IndexOf(Input, i)) != -1)
      {
        i += Input.Length;
        count++;
      }
      return count;
    }

  }
}
