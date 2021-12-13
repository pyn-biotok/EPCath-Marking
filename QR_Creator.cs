using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPCath_Marking
{
    class QR_Creator
    {
        public System.Drawing.Image QRImage;


        public System.Drawing.Image QR_Generator(Data d)
        {
            // это строка, которая будет записана в QR код
            string DataText = d.REF + "/" + d.LOT + "/" + d.SN + "/" + d.DATA1 + "/" + d.DATA2;

            // задаем параметр для позиции SN в зависимости от введенного значения (формат SN: ХХХ)
            switch (Int32.Parse(d.SN))
            {

                case int i1 when i1 >= 1 && i1 <= 9:
                    d.SN = "00" + d.SN;

                    break;

                case int i1 when i1 >= 10 && i1 <= 99:
                    d.SN = "0" + d.SN;

                    break;

            }


            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(DataText, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);

            QRImage = code.GetGraphic(2);

            return QRImage;

        }
            // метод по сохранению QR кода, пока без надобности
            void QR_saver(System.Drawing.Image QRimage)
            {
                if (QRimage != null) //если в pictureBox есть изображение
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
                            QRimage.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        catch
                        {
                            MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }

