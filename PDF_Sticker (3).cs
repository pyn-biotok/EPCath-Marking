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

namespace EPCath_Marking
{
    class PDF_Sticker 
    {
       public string path = "E:/BIOTOK_PDF.pdf";
        public string LOT, REF, SN, DATA, TYPE;
        public string  QR;
        public PDF_Sticker(string i_TYPE, string i_LOT, string i_SN, string i_Data, string i_QR)
        {
            LOT = i_LOT;
            TYPE = i_TYPE;
            SN = i_SN;
            DATA = i_Data;
            QR = i_QR;
                    }
        public void pfd_creator()
        {
            Document pdfdoc = new Document(iTextSharp.text.PageSize.A4, 1, 1, 1, 1);
            PdfWriter.GetInstance(pdfdoc, new FileStream(path, FileMode.Create));
            pdfdoc.SetPageSize(new iTextSharp.text.Rectangle(0, 0, 122, 71)); // изменяем размеры страницы 122, 71
            pdfdoc.Open(); // открываем дкоумент


            Paragraph p1 = new Paragraph("BIOTOK " + TYPE, FontFactory.GetFont("calibri", 8, Font.BOLD));
            p1.Alignment = Element.ALIGN_CENTER;
            pdfdoc.Add(p1);

            iTextSharp.text.Image QRimage = iTextSharp.text.Image.GetInstance(QR);
            QRimage.ScaleAbsolute(15f, 9.4f);

            iTextSharp.text.Image LOTimage = iTextSharp.text.Image.GetInstance("E:/SN.bmp");
           
            LOTimage.ScaleAbsolute(15f, 9.4f);


            PdfPTable table = new PdfPTable(3);
           // table.TotalWidth = 0;
           // table.DefaultCell.Border = Rectangle.NO_BORDER;
            // table.AddCell("Col 1 Row 1");
            //  pdfdoc.Add(table);
            //table.DefaultCell.Border = 0;

            var cell_LOT = new PdfPCell(LOTimage);
           
            var cell_SN = new PdfPCell(LOTimage);
            
            cell_LOT.Colspan = 3;
           
            table.AddCell(cell_LOT);
            table.AddCell(LOT);
            table.AddCell(SN);
            
            pdfdoc.Add(table);
            // table.DefaultCell.Border = Rectangle.NO_BORDER;
            // var QRimage = iTextSharp.text.Image.GetInstance(QR);
            //QRimage.Alignment = Element.ALIGN_RIGHT;
            //pdfdoc.Add(QRimage);


            /* Paragraph p2 = new Paragraph("LOT: " + LOT,FontFactory.GetFont("calibri", 8));
            p2.Alignment = Element.ALIGN_LEFT;
            pdfdoc.Add(p2);
           
            Chunk p3 = new Chunk("SN: " + SN, FontFactory.GetFont("calibri", 8));
            //p3.Alignment = Element.ALIGN_LEFT;
            pdfdoc.Add(p3);
            var QRimage = iTextSharp.text.Image.GetInstance(QR);
            QRimage.Alignment = Element.ALIGN_LEFT;
            pdfdoc.Add(QRimage);

            Paragraph p4 = new Paragraph(DATA, FontFactory.GetFont("calibri", 8));
            p4.Alignment = Element.ALIGN_LEFT;
            pdfdoc.Add(p4);*/




            pdfdoc.Close();
            System.Diagnostics.Process.Start("BIOTOK_PDF.pdf");





        }

        public void QR_creator()
        {
            
        }
       
           /* var QRimage = iTextSharp.text.Image.GetInstance(@"D:/QR.bmp");
        Paragraph p2 = new Paragraph();
        QRimage.SetAbsolutePosition(1, 1);
            pdfdoc.Add(p2);
            pdfdoc.Add(QRimage);
            */





    }
}
