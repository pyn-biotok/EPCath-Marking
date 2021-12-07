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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
      
        public void button1_Click(object sender, EventArgs e)
        {
            
        //this.StartPosition = FormStartPosition.CenterScreen;  //  форма в цендре окна


        DateTime date2 = new DateTime(Cath_Date1.Value.Year, Cath_Date1.Value.Month, Cath_Date1.Value.Day);
            date2 =  date2.AddYears(2);
           

            ResourceManager rm = Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject("REF");
            pictureBox1.Image = myImage;


            string Cath_Date2 = date2.Month.ToString() + "." + date2.Year.ToString();
            
            PDF_Sticker stick = new PDF_Sticker();
            stick.DataChecking(Cath_LOT.Text, Cath_QTY.Text);
            int SN = Convert.ToInt32(Cath_FirstSN.Text);
            int QTY = Convert.ToInt32(Cath_QTY.Text);
            // передаем в метод генератора QR кода необходимые данные
           // pictureBox1.Image = stick.QR_Generator(Cath_REF.Text, Cath_LOT.Text, SN, Cath_Date1.Text, Cath_Date2, QTY);
            
            // сохранение QR кода как картинки 
            QR_Creator QR_Code = new QR_Creator();
           QR_Code.QR_saver(pictureBox1.Image);

            // создание pdf документа 
            
           //
           stick.pdf_creator(Cath_REF.Text, Cath_LOT.Text, SN, Cath_Date1.Text, Cath_Date2, QTY);
           //stick.DataChecking();

            // MessageBox.Show("Создался PDF документ");


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
    }
}
