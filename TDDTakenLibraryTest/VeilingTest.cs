using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        [TestMethod]
        public void AlsErNogNietIsGebodenIsHetHoogsteBodNul()
        {
            var veiling = new Veiling();
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }

        [TestMethod]
        public void BijEenEersteBodIsHetHoogsteBodGelijkAanDitBedrag()
        {
            var veiling = new Veiling();
            var bod = 250m;
            veiling.DoeBod(bod);
            Assert.AreEqual(bod, veiling.HoogsteBod);
        }

        [TestMethod]
        public void AlsErMeerIsGebodenIsHetHoogsteBodGelijkAanHetHoogstGebodenBedrag()
        {
            var veiling = new Veiling();
            var bod = 250m;
            veiling.DoeBod(bod);
            var bod2 = 300m;
            veiling.DoeBod(bod2);
            Assert.AreEqual(bod2, veiling.HoogsteBod);
        }
    }
}
