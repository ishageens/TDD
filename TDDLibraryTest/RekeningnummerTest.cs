using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using System;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RekeningnummerTest
    {
        [TestMethod]
        public void NummerMet12CijfersMetCorrectControleIsOK()
        {
            new Rekeningnummer("063-1547564-61"); //dit nr mag geen exception veroorzaken
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet12CijfersMetVerkeerdeControleIsVerkeerd()
        {
            new Rekeningnummer("063-1547564-62");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet12CijfersZonderStreepjesMetCorrectControleIsNOK()
        {
            new Rekeningnummer("063154756461");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet13CijfersIsVerkeerd()
        {
            new Rekeningnummer("063-1547564-623");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet11CijfersIsVerkeerd()
        {
            new Rekeningnummer("063-1547564-6");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LeegNummerIsVerkeerd()
        {
            new Rekeningnummer(string.Empty);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void NummerMetNullIsVerkeerd()
        {
            new Rekeningnummer(null);
        }

        [TestMethod]
        public void ToStringMoetHetNummerTeruggeven()
        {
            var nummer = "063-1547564-61";
            var rekeningnummer = new Rekeningnummer(nummer);
            Assert.AreEqual(nummer, rekeningnummer.ToString());
        }
    }
}
