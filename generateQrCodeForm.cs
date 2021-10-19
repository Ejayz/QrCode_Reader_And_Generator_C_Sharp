using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace FaceRecognitionAttendanceSystem
{
    public partial class generateQrCodeForm : Form
    {
        QrCodeEncodingOptions options = new QrCodeEncodingOptions();


        public generateQrCodeForm()
        {
            InitializeComponent();
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 250,
                Height = 250,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
        }

        private void generateQrCodeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbQrCodeData.Text.Equals(""))
            {
                MessageBox.Show(this, "There is nothing to generate!", "Empty Input");
            }
            else
            {
                var qr = new BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.QR_CODE;
                var result = new Bitmap(qr.Write(tbQrCodeData.Text.Trim()));
                pbQrCodeDisplay.Image = result;
                tbQrCodeData.Clear();
            }
        }

        private void saveQrCode_Click(object sender, EventArgs e)
        {
            if (pbQrCodeDisplay.Image == null)
            {
                MessageBox.Show(this, "There is no qr code available in picture box!", "Empty Picture box");
            }
            else
            {

                int i = 1;
                String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Snippet/qrcodes/QrCode" + i.ToString() + ".png";
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Snippet/qrcodes/"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Snippet/qrcodes/");
                }

                while (File.Exists(path))
                {
                    i++;
                    path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Snippet/qrcodes/QrCode" + i.ToString() + ".png";
                }
                pbQrCodeDisplay.Image.Save(path, ImageFormat.Png);
                pbQrCodeDisplay.Image = null;
                MessageBox.Show(this,"Your file is saved in "+ path , "Saved");
            }
        }
    }
}
