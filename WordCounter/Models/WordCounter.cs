using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{

  public class RepeatCounter
  {
    public static string MasterString;
    public static List<RepeatCounter> InputWords = new List<RepeatCounter>() {};

    public RepeatCounter(string input)
    {
      Input = input;
      // InputWords.Add(input);
    }

    public string Input { get; set; }

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
