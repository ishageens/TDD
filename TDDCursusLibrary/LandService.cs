using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{
    public class LandService
    {
        // private LandDAO landDAO = new LandDAO();
        private readonly ILandDAO landDAO;
        // Constructor 
        public LandService(ILandDAO landDAO)
        {
            this.landDAO = landDAO;
        }
        public decimal FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden(string landcode)
        {
            //throw new NotImplementedException();

            var land = landDAO.Read(landcode);
            var oppervlakteAlleLanden = landDAO.OppervlakteAlleLanden();
            return (decimal)land.Oppervlakte / oppervlakteAlleLanden;
        }
    }
}
