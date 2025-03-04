namespace _2025TAP.Unit_2.U2P2
{
    partial class U2P2CustomButton
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
            myButton1 = new CustomButton.MyButton();
            myButton2 = new CustomButton.MyButton();
            myButton3 = new CustomButton.MyButton();
            myButton4 = new CustomButton.MyButton();
            SuspendLayout();
            // 
            // myButton1
            // 
            myButton1.BackColor = Color.IndianRed;
            myButton1.FlatAppearance.BorderSize = 0;
            myButton1.FlatStyle = FlatStyle.Flat;
            myButton1.ForeColor = Color.Black;
            myButton1.Location = new Point(12, 12);
            myButton1.Name = "myButton1";
            myButton1.Size = new Size(150, 40);
            myButton1.TabIndex = 0;
            myButton1.Text = "I am a button!";
            myButton1.UseVisualStyleBackColor = false;
            // 
            // myButton2
            // 
            myButton2.BackColor = Color.LimeGreen;
            myButton2.FlatAppearance.BorderSize = 0;
            myButton2.FlatStyle = FlatStyle.Flat;
            myButton2.ForeColor = Color.White;
            myButton2.Location = new Point(189, 12);
            myButton2.Name = "myButton2";
            myButton2.Size = new Size(150, 40);
            myButton2.TabIndex = 1;
            myButton2.Text = "I'm also a button!";
            myButton2.UseVisualStyleBackColor = false;
            // 
            // myButton3
            // 
            myButton3.BackColor = Color.LightSkyBlue;
            myButton3.FlatAppearance.BorderSize = 0;
            myButton3.FlatStyle = FlatStyle.Flat;
            myButton3.ForeColor = Color.White;
            myButton3.Location = new Point(16, 75);
            myButton3.Name = "myButton3";
            myButton3.Size = new Size(165, 68);
            myButton3.TabIndex = 2;
            myButton3.Text = "That's a lie!";
            myButton3.UseVisualStyleBackColor = false;
            // 
            // myButton4
            // 
            myButton4.BackColor = Color.Gold;
            myButton4.FlatAppearance.BorderColor = Color.Black;
            myButton4.FlatAppearance.BorderSize = 10;
            myButton4.FlatStyle = FlatStyle.Flat;
            myButton4.ForeColor = Color.Black;
            myButton4.Location = new Point(204, 83);
            myButton4.Name = "myButton4";
            myButton4.Size = new Size(174, 71);
            myButton4.TabIndex = 3;
            myButton4.Text = "That's not true!";
            myButton4.UseVisualStyleBackColor = false;
            // 
            // U2P2CustomButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 200);
            Controls.Add(myButton4);
            Controls.Add(myButton3);
            Controls.Add(myButton2);
            Controls.Add(myButton1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "U2P2CustomButton";
            Text = "U2P2 Clase Botón";
            ResumeLayout(false);
        }

        #endregion

        private CustomButton.MyButton myButton1;
        private CustomButton.MyButton myButton2;
        private CustomButton.MyButton myButton3;
        private CustomButton.MyButton myButton4;
    }
}