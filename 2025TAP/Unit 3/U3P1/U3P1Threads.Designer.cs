namespace _2025TAP.Unit_3.U3P1
{
    partial class U3P1Threads
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
            btnAlpha = new CustomButton.MyButton();
            btnBravo = new CustomButton.MyButton();
            btnCharlie = new CustomButton.MyButton();
            btnDelta = new CustomButton.MyButton();
            progressBar1 = new ProgressBar();
            btnStart = new CustomButton.MyButton();
            btnSuspend = new CustomButton.MyButton();
            btnResume = new CustomButton.MyButton();
            txtPB = new TextBox();
            SuspendLayout();
            // 
            // btnAlpha
            // 
            btnAlpha.BackColor = Color.DodgerBlue;
            btnAlpha.FlatAppearance.BorderSize = 0;
            btnAlpha.FlatStyle = FlatStyle.Flat;
            btnAlpha.Font = new Font("Consolas", 14F, FontStyle.Bold);
            btnAlpha.ForeColor = Color.White;
            btnAlpha.Location = new Point(31, 106);
            btnAlpha.Name = "btnAlpha";
            btnAlpha.Size = new Size(150, 40);
            btnAlpha.TabIndex = 0;
            btnAlpha.Text = "myButton1";
            btnAlpha.UseVisualStyleBackColor = false;
            // 
            // btnBravo
            // 
            btnBravo.BackColor = Color.DodgerBlue;
            btnBravo.FlatAppearance.BorderSize = 0;
            btnBravo.FlatStyle = FlatStyle.Flat;
            btnBravo.Font = new Font("Consolas", 14F, FontStyle.Bold);
            btnBravo.ForeColor = Color.White;
            btnBravo.Location = new Point(599, 143);
            btnBravo.Name = "btnBravo";
            btnBravo.Size = new Size(150, 40);
            btnBravo.TabIndex = 1;
            btnBravo.Text = "myButton2";
            btnBravo.UseVisualStyleBackColor = false;
            // 
            // btnCharlie
            // 
            btnCharlie.BackColor = Color.DodgerBlue;
            btnCharlie.FlatAppearance.BorderSize = 0;
            btnCharlie.FlatStyle = FlatStyle.Flat;
            btnCharlie.Font = new Font("Consolas", 14F, FontStyle.Bold);
            btnCharlie.ForeColor = Color.White;
            btnCharlie.Location = new Point(31, 282);
            btnCharlie.Name = "btnCharlie";
            btnCharlie.Size = new Size(150, 40);
            btnCharlie.TabIndex = 2;
            btnCharlie.Text = "myButton3";
            btnCharlie.UseVisualStyleBackColor = false;
            // 
            // btnDelta
            // 
            btnDelta.BackColor = Color.DodgerBlue;
            btnDelta.FlatAppearance.BorderSize = 0;
            btnDelta.FlatStyle = FlatStyle.Flat;
            btnDelta.Font = new Font("Consolas", 14F, FontStyle.Bold);
            btnDelta.ForeColor = Color.White;
            btnDelta.Location = new Point(599, 358);
            btnDelta.Name = "btnDelta";
            btnDelta.Size = new Size(150, 40);
            btnDelta.TabIndex = 3;
            btnDelta.Text = "myButton4";
            btnDelta.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(31, 219);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(718, 23);
            progressBar1.TabIndex = 4;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LimeGreen;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Consolas", 14F, FontStyle.Bold);
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(31, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 40);
            btnStart.TabIndex = 5;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnSuspend
            // 
            btnSuspend.BackColor = Color.Gold;
            btnSuspend.FlatAppearance.BorderSize = 0;
            btnSuspend.FlatStyle = FlatStyle.Flat;
            btnSuspend.Font = new Font("Consolas", 14F, FontStyle.Bold);
            btnSuspend.ForeColor = Color.Black;
            btnSuspend.Location = new Point(366, 12);
            btnSuspend.Name = "btnSuspend";
            btnSuspend.Size = new Size(150, 40);
            btnSuspend.TabIndex = 6;
            btnSuspend.Text = "Suspender";
            btnSuspend.UseVisualStyleBackColor = false;
            btnSuspend.Click += btnSuspend_Click;
            // 
            // btnResume
            // 
            btnResume.BackColor = Color.Orange;
            btnResume.FlatAppearance.BorderSize = 0;
            btnResume.FlatStyle = FlatStyle.Flat;
            btnResume.Font = new Font("Consolas", 14F, FontStyle.Bold);
            btnResume.ForeColor = Color.Black;
            btnResume.Location = new Point(548, 12);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(150, 40);
            btnResume.TabIndex = 7;
            btnResume.Text = "Continuar";
            btnResume.UseVisualStyleBackColor = false;
            btnResume.Click += btnResume_Click;
            // 
            // txtPB
            // 
            txtPB.Font = new Font("Segoe UI", 18F);
            txtPB.Location = new Point(200, 14);
            txtPB.Name = "txtPB";
            txtPB.Size = new Size(137, 39);
            txtPB.TabIndex = 8;
            // 
            // U3P1Threads
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPB);
            Controls.Add(btnResume);
            Controls.Add(btnSuspend);
            Controls.Add(btnStart);
            Controls.Add(progressBar1);
            Controls.Add(btnDelta);
            Controls.Add(btnCharlie);
            Controls.Add(btnBravo);
            Controls.Add(btnAlpha);
            Name = "U3P1Threads";
            Text = "U3P1Threads";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton.MyButton btnAlpha;
        private CustomButton.MyButton btnBravo;
        private CustomButton.MyButton btnCharlie;
        private CustomButton.MyButton btnDelta;
        private ProgressBar progressBar1;
        private CustomButton.MyButton btnStart;
        private CustomButton.MyButton btnSuspend;
        private CustomButton.MyButton btnResume;
        private TextBox txtPB;
    }
}