using System;
using System.Collections.Generic;
using System.Text;

namespace TDDTakenLibrary
{
    public class Veiling
    {
        public decimal hoogsteBod;

        public void DoeBod(decimal bedrag)
        {
            if (bedrag > hoogsteBod)
            {
                hoogsteBod = bedrag;
            }
        }

        public decimal HoogsteBod
        {
            get
            {
                return hoogsteBod;
            }
        }
    }
}
