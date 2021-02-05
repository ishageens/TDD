using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class ISBNTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ISBNMet13CijfersMetVerkeerdControleGetal2()
        {
            new ISBN(8789027439642L);
        }

        [TestMethod]
        public void ISBNMet13CijfersMetCorrectControleGetal2()
        {
            new ISBN(9789027439642L);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ISBNMet13CijfersMetVerkeerdControleGetal0()
        {
            new ISBN(7789227439640L);
        }

        [TestMethod]
        public void EenNummerMet13CijfersMetCorrectControleGetal0()
        {
            new ISBN(9789227439640L);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ISBNMet12CijfersIsNOK()
        {
            new ISBN(978902743964L);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ISBNMet14CijfersIsNOK()
        {
            new ISBN(97890274396424L);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ISBNMet0CijfersIsNOK()
        {
            new ISBN(0);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNegatiefNummerIsNOK()
        {
            new ISBN(-9789027439642L);
        }
    }
}
