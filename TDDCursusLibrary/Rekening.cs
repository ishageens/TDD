using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{
    public class Rekening
    {
        private decimal saldo;
        public void Storten(decimal bedrag)
        {
            //throw new NotImplementedException();
            saldo += bedrag;
        }

        public decimal Saldo
        {
            get
            {
                //throw new NotImplementedException();
                return saldo;
            }
        }
    }
}
