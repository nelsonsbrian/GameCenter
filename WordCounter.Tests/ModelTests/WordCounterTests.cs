using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounterTest
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void Master_ReturnMaster_True()
    {
      string test = "programmingisfun";
      RepeatCounter.MasterString = "programmingisfun";

      string result = RepeatCounter.MasterString;

      Assert.AreEqual(test, result);
    }
  }
}
