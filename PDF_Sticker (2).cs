using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace EPCath_Marking
{
    class PDF_Sticker 
    {
       public string path = "D:/BIOTOK_PDF.pdf";
        public string LOT, REF, SN, DATA, TYPE;
        public System.Drawing.Image = QR;
        public PDF_Sticker(string i_TYPE, string i_LOT, string i_SN, string i_Data, System.Drawing.Image i_QR)
        {
            LOT = i_LOT;
            TYPE = i_TYPE;
            SN = i_SN;
            DATA = i_Data;
            QR = i_QR;
            
        }
        public void pfd_creator()
        {
            Document pdfdoc = new Document(iTextSharp.text.PageSize.A4, 4, 4, 4, 4);
            PdfWriter.GetInstance(pdfdoc, new FileStream(path, FileMode.Create));
            pdfdoc.SetPageSize(new iTextSharp.text.Rectangle(0, 0, 122, 71)); // изменяем размеры страницы 122, 71
            pdfdoc.Open(); // открываем дкоумент
                    
            Paragraph p1 = new Paragraph(TYPE, FontFactory.GetFont("calibri", 8));
            
            pdfdoc.Add(p1);

            Paragraph p2 = new Paragraph(LOT,FontFactory.GetFont("calibri", 8));
            pdfdoc.Add(p2);

            Paragraph p3 = new Paragraph(SN, FontFactory.GetFont("calibri", 8));
            pdfdoc.Add(p3);

            Paragraph p4 = new Paragraph(DATA);
            pdfdoc.Add(p4);

            pdfdoc.Close(); 

        }

        public void QR_creator()
        {
            
        }


           /* var QRimage = iTextSharp.text.Image.GetInstance(@"D:/QR.bmp");
        Paragraph p2 = new Paragraph();
        QRimage.SetAbsolutePosition(1, 1);
            pdfdoc.Add(p2);
            pdfdoc.Add(QRimage);
            pdfdoc.Close();*/





    }
}
