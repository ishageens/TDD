using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDCursusLibrary;

namespace TDDLibraryTest
{
    [TestClass]
    public class RekeningTest
    {
        private Rekening rekening;

        [TestInitialize]
        public void Initialize()
        {
            rekening = new Rekening();
        }

        [TestMethod]
        public void SaldoNieuweRekeningIsNul()
        {
            //var rekening = new Rekening();
            Assert.AreEqual(decimal.Zero, rekening.Saldo);
        }

        [TestMethod]
        public void SaldoNaEersteStortingIsGelijkAanGestortBedrag()
        {
            //var rekening = new Rekening();
            var bedrag = 2.5m;
            rekening.Storten(bedrag);
            Assert.AreEqual(rekening.Saldo, bedrag);
        }

        [TestMethod]
        public void SaldoNaTweeStortingenIsGelijkAanSomVanBeideBedragen()
        {
            //var rekening = new Rekening();
            var bedrag1 = 2.5m;
            rekening.Storten(bedrag1);
            var bedrag2 = 1m;
            rekening.Storten(bedrag2);
            Assert.AreEqual(bedrag1 + bedrag2, rekening.Saldo);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetBedragVanEenStortingMagNietNulZijn()
        {
            rekening.Storten(decimal.Zero);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetBedragVanEenStortingMagNietNegatiefZijn()
        {
            rekening.Storten(-1m);
        }
    }
}
