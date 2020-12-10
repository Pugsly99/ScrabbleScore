using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScoreDictionaryTests
  {
    [TestMethod]
    public void ScoreDictionary_ReturnsKeyValueFromScoreDictionary_True()
    {
      int output = scoreDictionary["Z"];
      Assert.AreEqual(10, output);  
    }
  }
}