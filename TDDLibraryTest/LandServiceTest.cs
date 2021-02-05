using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using System;
using Moq;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private ILandDAO landDAO; // Stub 
        private LandService landService; // Te testen class 
        private Mock<ILandDAO> mockFactory;

        [TestInitialize]
        public void Initialize()
        {
            // landDAO = new LandDAOStub();
            mockFactory = new Mock<ILandDAO>();
            landDAO = mockFactory.Object;

            mockFactory.Setup(eenLandDAO => eenLandDAO.OppervlakteAlleLanden()).Returns(20);
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("B")).Returns(new Land { Landcode = "B", Oppervlakte = 5 });
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("NL")).Returns(new Land { Landcode = "NL", Oppervlakte = 6 });
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read(string.Empty)).Throws(new ArgumentException());

            landService = new LandService(landDAO);
        }

        [TestMethod]
        public void FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));
            // hier gaan we straks verifiëren of landService de methods 
            // read("B") en OppervlakteAlleALanden() heeft opgeroepen op landDAO. 
            mockFactory.Verify(eenLandDAO => eenLandDAO.OppervlakteAlleLanden());
            mockFactory.Verify(eenLandDAO => eenLandDAO.Read("B"));
        }
    }
}
