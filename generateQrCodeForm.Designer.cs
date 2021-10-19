
namespace FaceRecognitionAttendanceSystem
{
    partial class generateQrCodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pbQrCodeDisplay = new System.Windows.Forms.PictureBox();
            this.tbQrCodeData = new System.Windows.Forms.TextBox();
            this.saveQrCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCodeDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate QrCode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbQrCodeDisplay
            // 
            this.pbQrCodeDisplay.Location = new System.Drawing.Point(66, 28);
            this.pbQrCodeDisplay.Name = "pbQrCodeDisplay";
            this.pbQrCodeDisplay.Size = new System.Drawing.Size(250, 250);
            this.pbQrCodeDisplay.TabIndex = 1;
            this.pbQrCodeDisplay.TabStop = false;
            // 
            // tbQrCodeData
            // 
            this.tbQrCodeData.Location = new System.Drawing.Point(35, 284);
            this.tbQrCodeData.Multiline = true;
            this.tbQrCodeData.Name = "tbQrCodeData";
            this.tbQrCodeData.Size = new System.Drawing.Size(313, 60);
            this.tbQrCodeData.TabIndex = 2;
            // 
            // saveQrCode
            // 
            this.saveQrCode.Location = new System.Drawing.Point(35, 396);
            this.saveQrCode.Name = "saveQrCode";
            this.saveQrCode.Size = new System.Drawing.Size(313, 42);
            this.saveQrCode.TabIndex = 3;
            this.saveQrCode.Text = "Save QrCode";
            this.saveQrCode.UseVisualStyleBackColor = true;
            this.saveQrCode.Click += new System.EventHandler(this.saveQrCode_Click);
            // 
            // generateQrCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.saveQrCode);
            this.Controls.Add(this.tbQrCodeData);
            this.Controls.Add(this.pbQrCodeDisplay);
            this.Controls.Add(this.button1);
            this.Name = "generateQrCodeForm";
            this.Text = "generateQrCodeForm";
            this.Load += new System.EventHandler(this.generateQrCodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCodeDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbQrCodeDisplay;
        private System.Windows.Forms.TextBox tbQrCodeData;
        private System.Windows.Forms.Button saveQrCode;
    }
}