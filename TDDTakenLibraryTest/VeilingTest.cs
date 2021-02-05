using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;

        [TestInitialize]
        public void Initilialize()
        {
            veiling = new Veiling();
        }
        [TestMethod]
        public void AlsErNogNietIsGebodenIsHetHoogsteBodNul()
        {
            //var veiling = new Veiling();
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }

        [TestMethod]
        public void BijEenEersteBodIsHetHoogsteBodGelijkAanDitBedrag()
        {
            //var veiling = new Veiling();
            var bod = 250m;
            veiling.DoeBod(bod);
            Assert.AreEqual(bod, veiling.HoogsteBod);
        }

        [TestMethod]
        public void AlsErMeerIsGebodenIsHetHoogsteBodGelijkAanHetHoogstGebodenBedrag()
        {
            //var veiling = new Veiling();
            var bod = 250m;
            veiling.DoeBod(bod);
            var bod2 = 300m;
            veiling.DoeBod(bod2);
            var bod3 = 200m;
            veiling.DoeBod(bod3);
            Assert.AreNotEqual(bod3, veiling.HoogsteBod);
        }
    }
}
