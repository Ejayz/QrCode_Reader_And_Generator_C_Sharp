
namespace FaceRecognitionAttendanceSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbVideoBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCameraList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScanQrCode = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.generateQrCode = new System.Windows.Forms.Button();
            this.tbQrCodeResult = new System.Windows.Forms.TextBox();
            this.btnStopScanner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVideoBox
            // 
            this.pbVideoBox.Image = global::QrCode_Reader_And_Generator_C_Sharp.Properties.Resources.scanner;
            this.pbVideoBox.Location = new System.Drawing.Point(21, 12);
            this.pbVideoBox.Name = "pbVideoBox";
            this.pbVideoBox.Size = new System.Drawing.Size(446, 267);
            this.pbVideoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVideoBox.TabIndex = 0;
            this.pbVideoBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Camera Device";
            // 
            // cbCameraList
            // 
            this.cbCameraList.FormattingEnabled = true;
            this.cbCameraList.Location = new System.Drawing.Point(248, 310);
            this.cbCameraList.Name = "cbCameraList";
            this.cbCameraList.Size = new System.Drawing.Size(219, 23);
            this.cbCameraList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(473, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scanned Data:";
            // 
            // btnScanQrCode
            // 
            this.btnScanQrCode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScanQrCode.Location = new System.Drawing.Point(495, 132);
            this.btnScanQrCode.Name = "btnScanQrCode";
            this.btnScanQrCode.Size = new System.Drawing.Size(219, 31);
            this.btnScanQrCode.TabIndex = 5;
            this.btnScanQrCode.Text = "Start Scanner";
            this.btnScanQrCode.UseVisualStyleBackColor = true;
            this.btnScanQrCode.Click += new System.EventHandler(this.btnScanQrCode_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // generateQrCode
            // 
            this.generateQrCode.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateQrCode.Location = new System.Drawing.Point(495, 169);
            this.generateQrCode.Name = "generateQrCode";
            this.generateQrCode.Size = new System.Drawing.Size(219, 31);
            this.generateQrCode.TabIndex = 6;
            this.generateQrCode.Text = "Generate Qr Code";
            this.generateQrCode.UseVisualStyleBackColor = true;
            this.generateQrCode.Click += new System.EventHandler(this.generateQrCode_Click);
            // 
            // tbQrCodeResult
            // 
            this.tbQrCodeResult.Location = new System.Drawing.Point(619, 13);
            this.tbQrCodeResult.Multiline = true;
            this.tbQrCodeResult.Name = "tbQrCodeResult";
            this.tbQrCodeResult.Size = new System.Drawing.Size(314, 114);
            this.tbQrCodeResult.TabIndex = 7;
            // 
            // btnStopScanner
            // 
            this.btnStopScanner.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStopScanner.Location = new System.Drawing.Point(739, 133);
            this.btnStopScanner.Name = "btnStopScanner";
            this.btnStopScanner.Size = new System.Drawing.Size(172, 30);
            this.btnStopScanner.TabIndex = 8;
            this.btnStopScanner.Text = "Stop Scanner";
            this.btnStopScanner.UseVisualStyleBackColor = true;
            this.btnStopScanner.Click += new System.EventHandler(this.btnStopScanner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 380);
            this.Controls.Add(this.btnStopScanner);
            this.Controls.Add(this.tbQrCodeResult);
            this.Controls.Add(this.generateQrCode);
            this.Controls.Add(this.btnScanQrCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCameraList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbVideoBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVideoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVideoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCameraList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScanQrCode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button generateQrCode;
        private System.Windows.Forms.TextBox tbQrCodeResult;
        private System.Windows.Forms.Button btnStopScanner;
    }
}

