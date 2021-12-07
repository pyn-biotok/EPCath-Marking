using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCath_Marking
{
    class Data
    {
        public string LOT, REF, SN, DATA1, DATA2;

        public void DataList(string _SN, string _LOT, string _REF, string _DATA1, string _DATA2)
        {
            LOT = _LOT;
            SN = _SN;
            REF = _REF;
            DATA1 = _DATA1;
            DATA2 = _DATA2;
        }
    }
}
