﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;
using Moq;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private WinstService winstService;
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;

        private Mock<IKostDAO> mockKostDAO;
        private Mock<IOpbrengstDAO> mockOpbrengstDAO;

        [TestInitialize]
        public void Initialize()
        {
            //kostDAO = new KostDAOStub();
            //opbrengstDAO = new OpbrengstDAOStub();

            mockKostDAO = new Mock<IKostDAO>();
            mockOpbrengstDAO = new Mock<IOpbrengstDAO>();
            kostDAO = mockKostDAO.Object;
            opbrengstDAO = mockOpbrengstDAO.Object;
            mockOpbrengstDAO.Setup(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst()).Returns(200m);
            mockKostDAO.Setup(eenKostDAO => eenKostDAO.TotaleKost()).Returns(169m);

            winstService = new WinstService(opbrengstDAO, kostDAO);
        }

        [TestMethod]
        public void WinstIsOpbrengstMinKost()
        {
            Assert.AreEqual(31m, winstService.Winst);

            mockKostDAO.Verify(eenKostDAO => eenKostDAO.TotaleKost());
            mockOpbrengstDAO.Verify(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst());
        }
    }
}