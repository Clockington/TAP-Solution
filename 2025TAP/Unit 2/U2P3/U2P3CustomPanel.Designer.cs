namespace _2025TAP.Unit_2.U2P3
{
    partial class U2P3CustomPanel
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
            myPanel1 = new CustomControlPanel.MyPanel();
            SuspendLayout();
            // 
            // myPanel1
            // 
            myPanel1.BackColor = Color.SkyBlue;
            myPanel1.BorderStyle = BorderStyle.FixedSingle;
            myPanel1.ForeColor = Color.White;
            myPanel1.Location = new Point(12, 12);
            myPanel1.Name = "myPanel1";
            myPanel1.Padding = new Padding(10);
            myPanel1.Size = new Size(646, 224);
            myPanel1.TabIndex = 0;
            // 
            // U2P3CustomPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 253);
            Controls.Add(myPanel1);
            Name = "U2P3CustomPanel";
            Text = "U2P3CustomPanel";
            ResumeLayout(false);
        }

        #endregion

        private CustomControlPanel.MyPanel myPanel1;
    }
}