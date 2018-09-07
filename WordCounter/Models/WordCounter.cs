using System;
using System.Collections.Generic;

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

  }
}
