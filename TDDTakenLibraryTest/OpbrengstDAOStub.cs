using System;
using System.Collections.Generic;
using System.Text;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    class OpbrengstDAOStub : IOpbrengstDAO
    {
        public decimal TotaleOpbrengst()
        {
            return 200m;
        }
    }
}
