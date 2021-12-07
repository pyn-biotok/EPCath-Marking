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
            string QR_info = Cath_Type.Text;
            QRCodeGenerator qr = new QRCodeGenerator();
          
            QRCodeData data = qr.CreateQrCode(QR_info, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            
            pictureBox1.Image = code.GetGraphic(1);

            PDF_Sticker stick = new PDF_Sticker(Cath_Type.Text, Cath_Lot.Text, Cath_SN.Text, Date_of_prod.Text, pictureBox1.Image);
            stick.pfd_creator();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        public void button2_Click(object sender, EventArgs e)
        {




            /* Document pdfdoc = new Document(iTextSharp.text.PageSize.A4, 4, 4, 4, 4); // создаем пдф документ 
             PdfWriter.GetInstance(pdfdoc, new FileStream("D:/BIOTOK_PDF.pdf", FileMode.Create)); // задаем имя, пцуть документа

             pdfdoc.SetPageSize(new iTextSharp.text.Rectangle(0, 0, 122, 71)); // изменяем размеры страницы 122, 71
             pdfdoc.Open(); // открываем дкоумент
            PDF_Generate.Text = QR_info;
             Paragraph p1 = new Paragraph(QR_info);

            pdfdoc.Add(p1);
            // pdfdoc.NewPage();

             var QRimage = iTextSharp.text.Image.GetInstance(@"D:/QR.bmp");
             Paragraph p2 = new Paragraph();
             QRimage.SetAbsolutePosition(1, 1);
             pdfdoc.Add(p2);
             pdfdoc.Add(QRimage);
             pdfdoc.Close();

             */


            MessageBox.Show("Creating");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
