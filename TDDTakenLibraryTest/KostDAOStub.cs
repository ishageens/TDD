using System;
using System.Collections.Generic;
using System.Text;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    class KostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            return 169m;
        }
    }
}
