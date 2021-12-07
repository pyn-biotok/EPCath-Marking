using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows;
using System.Threading;
using System.Windows.Forms;
using QRCoder;


namespace EPCath_Marking
{
  
    class PDF_Sticker
    {
        private string SN_Text;
        // переменная, где будет храниться сгенеренный QR код 
        private System.Drawing.Image QRimage;

        // переменная пути, где будет сохраняться pdf документ
        public string path;
        public string LOT, REF, DATA1, DATA2;
        int SN, QTY;

        public int DataChecking(string _LOT, string _QTY)
        {
            try
            {
                if (_LOT != null)

                    return 1;   
                



            }
            catch
            {
                if (_LOT == null)

                     System.Windows.Forms.MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            return 1;
        }
        // метод генерирования QR кода
        public void pdf_creator(string i_REF, string i_LOT, int i_SN, string i_Data1, string i_Data2, int i_QTY)
        {
            LOT = i_LOT;
            REF = i_REF;
            SN = i_SN;
            DATA1 = i_Data1;
            DATA2 = i_Data2;
            QTY = i_QTY;
           // DataChecking();
            pfdListData_creator();

            
        }

        public void pfdListData_creator()
        {
            // прописываем путь сохранения pdf докумета
            path = "D:/" + REF + "_" + DATA1 + ".pdf";

            // создаем страницу формата А4
            Document pdfdoc = new Document(iTextSharp.text.PageSize.A4, 1, 1, 1, 1);
            PdfWriter.GetInstance(pdfdoc, new FileStream(path, FileMode.Create));

            // меняем размеры страницы под размеры стикера (нужный размер в дюймах умножаем на 72)
            pdfdoc.SetPageSize(new iTextSharp.text.Rectangle(0, 0, 122, 71));

            // открываем документ
            pdfdoc.Open();

            int i ;
            for (i = 1; i <= QTY; i++)
            {
                
                CreatePDFListData(SN);
                pdfdoc.NewPage();
                SN++;
            }
           

            pdfdoc.Close();
            System.Diagnostics.Process.Start(path);


            void CreatePDFListData(int i_SN)
            {
                SN = i_SN;
                                         
                             
                QR_Generator();
                // получаем сгенерированную картинку QR кода, конвертируем в iTextSharp.text.Image    
                iTextSharp.text.Image QRPic = iTextSharp.text.Image.GetInstance(QRimage, System.Drawing.Imaging.ImageFormat.Bmp);
                QRPic.ScaleAbsolute(40f, 40f);
                QRPic.SetAbsolutePosition(pdfdoc.PageSize.Width - QRPic.Width + 35f, pdfdoc.PageSize.Height - QRPic.Height +35f);

                // - QRPic.Width + 1f
                // - QRPic.Height
                pdfdoc.Add(QRPic);

                float spack = 2f;

                Phrase c3 = new Phrase();
                c3 = Pic_Text("D:/SN.bmp", SN_Text);
                Phrase c4 = new Phrase();
                c4 = Pic_Text("D:/LOT.bmp", LOT);

                Phrase c5 = new Phrase("   ");

                Paragraph par3 = new Paragraph();
                par3.SpacingBefore = -3.5f;
                par3.SpacingAfter = spack;
                par3.Add(c3);
                par3.Add(c5);
                par3.Add(c4);
                pdfdoc.Add(par3);


                Phrase c6 = new Phrase();
                c6 = Pic_Text("D:/REF.bmp", REF);
                Paragraph par4 = new Paragraph();
                par4.SpacingBefore = spack;
                par4.SpacingAfter = spack;
                par4.Add(c6);
                pdfdoc.Add(par4);



                Phrase c1 = new Phrase();
                c1 = Pic_Text("D:/DATA1.bmp", DATA1);
                Phrase c2 = new Phrase();
                c2 = Pic_Text("D:/DATA2.bmp", DATA2);
                Phrase c7 = new Phrase("   ");

                Paragraph par1 = new Paragraph();
                par1.SpacingBefore = spack;
                par1.SpacingAfter = -6;
                par1.Add(c1);
                par1.Add(c7);
                par1.Add(c2);
                pdfdoc.Add(par1);

             

                
                


                
               



            }
           

            void QR_Generator()
            {

               
               

                switch (SN)
                    {

                    case int i1 when i1 >= 1  && i1 <= 9:
                        SN_Text = "00" + SN.ToString();
                                              
                        break;

                    case int i1 when i1 >= 10 && i1 <= 99:
                        SN_Text = "0" + SN.ToString();

                        break;

                    case int i1 when i1 >= 100 && i1 <= 999:
                        SN_Text =  SN.ToString();

                        break;

                }

                //  формируем строку, которая запишется в QR код
                string QR_info = REF + "/" + LOT + "/" + SN_Text + "/" + DATA1 + "/" + DATA2;

                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(QR_info, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);

                QRimage = code.GetGraphic(2);
                

                // return QRimage;


            }
            
          

            Phrase Pic_Text(string path, string info)
            {
                iTextSharp.text.Image Pic = iTextSharp.text.Image.GetInstance(path);
                
                switch (path)
                {
                    case "D:/LOT.bmp":
                        Pic.ScaleAbsolute(15.5f, 11.2f);
                        break;

                    case "D:/REF.bmp":
                        Pic.ScaleAbsolute(15.5f, 11.2f);
                        break;

                    case "D:/SN.bmp":
                        Pic.ScaleAbsolute(15.5f, 11.2f);
                        break;

                    case "D:/DATA1.bmp":
                        Pic.ScaleAbsolute(12.6f, 12.6f);
                        break;

                    case "D:/DATA2.bmp":
                        Pic.ScaleAbsolute(10.1f, 13.8f);
                        break;
                }
               
                
               

                Chunk pic = new Chunk(Pic, 0, 0);
                Chunk tab = new Chunk(" ");
                Chunk text = new Chunk(info, FontFactory.GetFont("arial", (float) 7f,  Font.UNDERLINE));
                Phrase PicText = new Phrase();
                PicText.Add(pic);
                PicText.Add(tab);
                PicText.Add(text);




                return PicText;





            }
         
           
                
       
        }


    }
}
