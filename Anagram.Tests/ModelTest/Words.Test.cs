using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Anagram newAnagram = new Anagram("test");
      Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
    }

  }
}
