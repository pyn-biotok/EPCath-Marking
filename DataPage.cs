using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCath_Marking
{
   public class DataPage
    {
       
       public string REF, LOT, SN, DATA1, DATA2, QTY;


        public void CreatePage(string _REF, string _LOT, string _SN, string _DATA1, string _DATA2)
        {
            REF = _REF;
            LOT = _LOT;
            SN = _SN;
            DATA1 = _DATA1;
            DATA2 = _DATA2;


        }
    }




}
