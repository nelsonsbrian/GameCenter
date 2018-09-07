using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{

  public class RepeatCounter
  {
    public static string MasterString;
    private string _input;
    public RepeatCounter(string input)
    {
      _input = input;
    }

    public string GetInput()
    {
      return _input;
    }

    public void SetInput(string input)
    {
      _input = input;
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
