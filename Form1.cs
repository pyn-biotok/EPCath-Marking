using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
using EPCath_Marking.Properties;
using System.Resources;

namespace EPCath_Marking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                
        }

       

        public void button1_Click(object sender, EventArgs e)
        {
     
            // настраиваем дату истечения срока годности
        DateTime data2 = new DateTime(Cath_Date1.Value.Year, Cath_Date1.Value.Month, Cath_Date1.Value.Day);
        data2 =  data2.AddYears(2);
        string Cath_Data2 = data2.Month.ToString() + "." + data2.Year.ToString();

            // создаем объект Data, там хранятся все даныне на конкретный лист стикера
        Data data = new Data(Cath_FirstSN.Text, Cath_LOT.Text, Cath_REF.Text, Cath_Date1.Text, Cath_Data2);
                          
            // создаем страницу (стикер) PDF документа
        PDF_Sticker stick = new PDF_Sticker();
        stick.PDF_Sticker_Creator(data, Cath_QTY.Text);
                     
        }

      
        private void Cath_LOT_MouseEnter(object sender, EventArgs e)
        {
                        
        ToolTip t = new ToolTip();
            t.SetToolTip(Cath_LOT, "Формат кода партии: ХХХ ");

        }

       
    }
}
