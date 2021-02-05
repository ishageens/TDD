using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private ILandDAO landDAO; // Stub 
        private LandService landService; // Te testen class 

        [TestInitialize]
        public void Initialize()
        {
            landDAO = new LandDAOStub();
            landService = new LandService(landDAO);
        }

        [TestMethod]
        public void FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));
        }
    }
}
