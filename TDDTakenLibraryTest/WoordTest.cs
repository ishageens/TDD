using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void LepelIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom01());
        }

        [TestMethod]
        public void VorkIsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("vork").IsPalindroom01());
        }
    }
}
