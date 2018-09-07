using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{

  public class RepeatCounter
  {
    public static string MasterString;
    public static List<RepeatCounter> InputWords = new List<RepeatCounter>() {};
    private string _input;
    public RepeatCounter(string input)
    {
      _input = input;
      // InputWords.Add(input);
    }

    public string GetInput()
    {
      return _input;
    }

    public void SetInput(string input)
    {
      _input = input;
    }

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
      while ((i = MasterString.IndexOf(_input, i)) != -1)
      {
        i += _input.Length;
        count++;
      }
      return count;
    }

  }
}
