using System;
using System.Collections.Generic;
using System.Text;

namespace TDDTakenLibrary
{
    public class WinstService
    {
        private readonly IKostDAO kostDAO;
        private readonly IOpbrengstDAO opbrengstDAO;

        public WinstService(IOpbrengstDAO opbrengstDAO, IKostDAO kostDAO)
        {
            this.opbrengstDAO = opbrengstDAO;
            this.kostDAO = kostDAO;
        }

        public Decimal Winst
        {
            get
            {
                // throw new NotImplementedException(); 
                return opbrengstDAO.TotaleOpbrengst() - kostDAO.TotaleKost();
            }
        }
    }
}
