using AForge.Video.DirectShow;
using System;
using System.Windows.Forms;
using ZXing;
using System.Drawing;
using QrCode_Reader_And_Generator_C_Sharp.Properties;

namespace FaceRecognitionAttendanceSystem
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection filter;
        private  VideoCaptureDevice captureDevice;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Devices in filter)
            {

                cbCameraList.Items.Add(Devices.Name);
            }

            cbCameraList.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();
            timer1.Start();
        }

        private void btnScanQrCode_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[cbCameraList.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pbVideoBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pbVideoBox.Image);
            if (result != null)
            {
                tbQrCodeResult.Text = result.ToString();
            }
            else
            {
                Console.WriteLine("Scanning for qr code");
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning == true)
            {
                timer1.Stop();
                captureDevice.SignalToStop();
            }
        }

        private void generateQrCode_Click(object sender, EventArgs e)
        {
            new generateQrCodeForm().Show();
        }

        private void btnStopScanner_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning == true)
            {
                timer1.Stop();
                pbVideoBox.Image = Resources.scanner;   
                captureDevice.SignalToStop();
            }
        }
    }
}
