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

        private void Date_of_prod_ValueChanged(object sender, EventArgs e)
        {
            //  задаем пользовательскую фрму даты и времени
            
            Cath_Date1.Format = DateTimePickerFormat.Custom; 
            Cath_Date1.CustomFormat = "MM.yyyy";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cath_LOT_MouseEnter(object sender, EventArgs e)
        {

            
ToolTip t = new ToolTip();
            t.SetToolTip(Cath_LOT, "Формат кода партии: ХХХ ");

        }

        private void Cath_FirstSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            {

                if (Char.IsDigit(e.KeyChar)) return;
                else
                    e.Handled = true;
            }
        }

        private void Cath_QTY_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Cath_LOT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Cath_QTY_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Cath_QTY_Validating(object sender, CancelEventArgs e)
        {
            if (Cath_QTY.Text.Length != 0)
            {
                progressBar1.PerformStep();
            }
            else progressBar1.Value -= progressBar1.Step;
        }

        private void Cath_Date1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cath_REF_Validating(object sender, CancelEventArgs e)
        {
            if (Cath_REF.Text.Length != 0)
            {
                
                progressBar1.PerformStep();

            }
            else progressBar1.Step -= progressBar1.Step;

        }
    }
}
