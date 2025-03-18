namespace ITT2025_TAP
{
    partial class U1P3Images
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U1P3Images));
            btnLoadImage = new Button();
            pictureBox1 = new PictureBox();
            ImageLocation = new TextBox();
            btnConvertBmp = new Button();
            btnConvertJpeg = new Button();
            btnConvertPng = new Button();
            btnConvertGif = new Button();
            tipLoadImage = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoadImage
            // 
            btnLoadImage.BackColor = Color.Firebrick;
            btnLoadImage.Cursor = Cursors.Hand;
            btnLoadImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLoadImage.ForeColor = SystemColors.ButtonFace;
            btnLoadImage.Location = new Point(251, 303);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(150, 60);
            btnLoadImage.TabIndex = 0;
            btnLoadImage.Text = "Cargar Imagen";
            btnLoadImage.UseVisualStyleBackColor = false;
            btnLoadImage.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(628, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ImageLocation
            // 
            ImageLocation.Location = new Point(12, 251);
            ImageLocation.Name = "ImageLocation";
            ImageLocation.ReadOnly = true;
            ImageLocation.Size = new Size(628, 27);
            ImageLocation.TabIndex = 2;
            ImageLocation.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConvertBmp
            // 
            btnConvertBmp.BackColor = Color.ForestGreen;
            btnConvertBmp.Cursor = Cursors.Hand;
            btnConvertBmp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConvertBmp.Location = new Point(16, 378);
            btnConvertBmp.Name = "btnConvertBmp";
            btnConvertBmp.Size = new Size(150, 60);
            btnConvertBmp.TabIndex = 3;
            btnConvertBmp.Text = "Convertir a\r\n\".bmp\"";
            btnConvertBmp.UseVisualStyleBackColor = false;
            btnConvertBmp.Click += button2_Click;
            // 
            // btnConvertJpeg
            // 
            btnConvertJpeg.BackColor = Color.DarkCyan;
            btnConvertJpeg.Cursor = Cursors.Hand;
            btnConvertJpeg.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConvertJpeg.Location = new Point(172, 378);
            btnConvertJpeg.Name = "btnConvertJpeg";
            btnConvertJpeg.Size = new Size(150, 60);
            btnConvertJpeg.TabIndex = 4;
            btnConvertJpeg.Text = "Convertir a\r\n\".jpeg\"";
            btnConvertJpeg.UseVisualStyleBackColor = false;
            btnConvertJpeg.Click += btnConvertJpeg_Click;
            // 
            // btnConvertPng
            // 
            btnConvertPng.BackColor = Color.Gold;
            btnConvertPng.Cursor = Cursors.Hand;
            btnConvertPng.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConvertPng.Location = new Point(328, 378);
            btnConvertPng.Name = "btnConvertPng";
            btnConvertPng.Size = new Size(150, 60);
            btnConvertPng.TabIndex = 5;
            btnConvertPng.Text = "Convertir a\r\n\".png\"";
            btnConvertPng.UseVisualStyleBackColor = false;
            // 
            // btnConvertGif
            // 
            btnConvertGif.BackColor = Color.Fuchsia;
            btnConvertGif.Cursor = Cursors.Hand;
            btnConvertGif.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConvertGif.Location = new Point(484, 378);
            btnConvertGif.Name = "btnConvertGif";
            btnConvertGif.Size = new Size(150, 60);
            btnConvertGif.TabIndex = 6;
            btnConvertGif.Text = "Convertir a\"\r\n.gif\"";
            btnConvertGif.UseVisualStyleBackColor = false;
            // 
            // U1P3Images
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(652, 453);
            Controls.Add(btnConvertGif);
            Controls.Add(btnConvertPng);
            Controls.Add(btnConvertJpeg);
            Controls.Add(btnConvertBmp);
            Controls.Add(ImageLocation);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoadImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(670, 500);
            MinimumSize = new Size(670, 500);
            Name = "U1P3Images";
            Text = "U1P3 Cargar Imagen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadImage;
        private PictureBox pictureBox1;
        private TextBox ImageLocation;
        private Button btnConvertBmp;
        private Button btnConvertJpeg;
        private Button btnConvertPng;
        private Button btnConvertGif;
        private ToolTip tipLoadImage;
    }
}