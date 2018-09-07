using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

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

      string result = newWord.GetInput();

      Assert.AreEqual(test, result);
    }

    [TestMethod] // test 3
    public void GetInput_IsEqualtoMaster_True()
    {
      string test = "tissue";
      RepeatCounter newWord = new RepeatCounter(test);
      RepeatCounter.MasterString = "tissue";

      string result = newWord.GetInput();

      Assert.AreEqual(RepeatCounter.MasterString, result);
    }

    [TestMethod] // test 4
    public void RepeatCount_ReturnCount_3()
    {
      string test = "an";
      RepeatCounter newWord = new RepeatCounter(test);
      RepeatCounter.MasterString = "banana";

      int result = newWord.RepeatCount();

      Assert.AreEqual(2, result);
    }

  }
}
