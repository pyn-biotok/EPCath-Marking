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


    public class PDF_Sticker
    {
       
        System.Drawing.Image QRImage;

        public string DiskName = Environment.CurrentDirectory.ToString();

     
        public void PDF_Sticker_Creator(Data d, string QTY)
        {

            // прописываем путь и имя PDF файла для сохранения
            string path = DiskName + "/" +  d.REF + "_" + d.DATA1 + ".pdf";

            // тут короче создается PDF документ и вся херня
            Document pdfdoc = new Document(iTextSharp.text.PageSize.A4, 1, 1, 1, 1);
            PdfWriter.GetInstance(pdfdoc, new FileStream(path, FileMode.Create));
            pdfdoc.SetPageSize(new iTextSharp.text.Rectangle(0, 0, 122, 71));

            pdfdoc.Open();

            
            int i;
            int _SN = Int32.Parse(d.SN);
            for (i = 1; i <= Int32.Parse(QTY); i++)
            {
                QR_Creator qr = new QR_Creator();
                QRImage = qr.QR_Generator(d);

                CreatePDFListData(_SN, QRImage);
                pdfdoc.NewPage();
                _SN++;

            }


            pdfdoc.Close();
            System.Diagnostics.Process.Start(path);


            void CreatePDFListData(int SN, System.Drawing.Image QRCode)
            {


                // получаем сгенерированную картинку QR кода, конвертируем в iTextSharp.text.Image    
                iTextSharp.text.Image QRPic = iTextSharp.text.Image.GetInstance(QRCode, System.Drawing.Imaging.ImageFormat.Bmp);
                QRPic.ScaleAbsolute(40f, 40f);
                QRPic.SetAbsolutePosition(pdfdoc.PageSize.Width - QRPic.Width + 35f, pdfdoc.PageSize.Height - QRPic.Height + 35f);

                 pdfdoc.Add(QRPic);

                float spack = 2f;
                 
             Phrase c3 = new Phrase();
                c3 = Pic_Text(DiskName + "/SN.bmp", SN.ToString());
                Phrase c4 = new Phrase();
                c4 = Pic_Text(DiskName + "/LOT.bmp", d.LOT);

                Phrase c5 = new Phrase("   ");

                Paragraph par3 = new Paragraph();
                par3.SpacingBefore = -3.5f;
                par3.SpacingAfter = spack;
                par3.Add(c3);
                par3.Add(c5);
                par3.Add(c4);
                pdfdoc.Add(par3);


                Phrase c6 = new Phrase();
                c6 = Pic_Text(DiskName + "/REF.bmp", d.REF);
                Paragraph par4 = new Paragraph();
                par4.SpacingBefore = spack;
                par4.SpacingAfter = spack;
                par4.Add(c6);
                pdfdoc.Add(par4);


                Phrase c1 = new Phrase();
                c1 = Pic_Text(DiskName + "/DATA1.bmp", d.DATA1);
                Phrase c2 = new Phrase();
                c2 = Pic_Text(DiskName + "/DATA2.bmp", d.DATA2);
                Phrase c7 = new Phrase("   ");

                Paragraph par1 = new Paragraph();
                par1.SpacingBefore = spack;
                par1.SpacingAfter = -6;
                par1.Add(c1);
                par1.Add(c7);
                par1.Add(c2);
                pdfdoc.Add(par1);




            }


        }


        Phrase Pic_Text(string path2, string info)
        {
            
              
           string result = Path.GetFileName(path2);
            iTextSharp.text.Image Pic = iTextSharp.text.Image.GetInstance(path2);
            
            switch (result)
            {
                case "LOT.bmp":
                    Pic.ScaleAbsolute(15.5f, 11.2f);
                    break;

                case "REF.bmp":
                    Pic.ScaleAbsolute(15.5f, 11.2f);
                    break;

                case "SN.bmp":
                    Pic.ScaleAbsolute(15.5f, 11.2f);
                    break;

                case "DATA1.bmp":
                    Pic.ScaleAbsolute(12.6f, 12.6f);
                    break;

                case "DATA2.bmp":
                    Pic.ScaleAbsolute(10.1f, 13.8f);
                    break;
            }




            Chunk pic = new Chunk(Pic, 0, 0);
            Chunk tab = new Chunk(" ");
            Chunk text = new Chunk(info, FontFactory.GetFont("arial", (float)7f, Font.UNDERLINE));
            Phrase PicText = new Phrase();
            PicText.Add(pic);
            PicText.Add(tab);
            PicText.Add(text);




            return PicText;





        }
    }
}
         
           
                
       
      


