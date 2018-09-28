using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System;
using System.Linq;
using WordCounter.Models;

namespace WordCounterTest
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod] // test 1
    public void Master_ReturnMaster_True()
    {
      string test = "programmingisfun";
      RepeatCounter.MasterString = "programmingisfun";

      string result = RepeatCounter.MasterString;

      Assert.AreEqual(test, result);
    }

    [TestMethod] // test 2
    public void Input_ReturnInput_True()
    {
      string test = "fun";
      RepeatCounter newWord = new RepeatCounter("fun");

      string result = newWord.Input;

      Assert.AreEqual(test, result);
    }

    [TestMethod] // test 3
    public void Input_IsEqualtoMaster_True()
    {
      string test = "tissue";
      RepeatCounter newWord = new RepeatCounter(test);
      RepeatCounter.MasterString = "tissue";

      string result = newWord.Input;

      Assert.AreEqual(RepeatCounter.MasterString, result);
    }

    [TestMethod] // test 4
    public void RepeatCount_ReturnCount_2_True()
    {
      string test = "an";
      RepeatCounter newWord = new RepeatCounter(test);
      RepeatCounter.MasterString = "banana";

      int result = newWord.RepeatCount();

      Assert.AreEqual(2, result);
    }

    [TestMethod] // test 5
    public void WordCount_ArrayIs2And2_True()
    {
      int[] test = new int[] {2, 2};
      RepeatCounter newWord1 = new RepeatCounter("an");
      RepeatCounter.InputWords.Add(newWord1);
      RepeatCounter newWord2 = new RepeatCounter("na");
      RepeatCounter.InputWords.Add(newWord2);
      RepeatCounter.MasterString = "banana";

      int[] result = RepeatCounter.WordCount();

      Assert.AreEqual(true, test.SequenceEqual(result));
    }

  }
}
