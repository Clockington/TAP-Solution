namespace _2025TAP.Unit_1.U1P1.Multiplication
{
    partial class U1P1Multiplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtOutput = new TextBox();
            txtInput = new TextBox();
            txtConversion = new TextBox();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 30);
            label1.TabIndex = 0;
            label1.Text = "Conversión de MXN a USD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 1;
            label2.Text = "Pesos Mexicanos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(21, 100);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 2;
            label3.Text = "Tipo de Cambio:";
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(96, 189);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(173, 145);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(100, 23);
            txtOutput.TabIndex = 6;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(173, 55);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 7;
            // 
            // txtConversion
            // 
            txtConversion.Location = new Point(173, 98);
            txtConversion.Name = "txtConversion";
            txtConversion.Size = new Size(100, 23);
            txtConversion.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(229, 185);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(65, 147);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 10;
            label4.Text = "Resultado:";
            // 
            // U1P1Multiplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(txtConversion);
            Controls.Add(txtInput);
            Controls.Add(txtOutput);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(400, 600);
            MinimizeBox = false;
            MinimumSize = new Size(400, 600);
            Name = "U1P1Multiplication";
            Text = "Multiplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private MaskedTextBox mtxtInput;
        private MaskedTextBox maskedTextBox2;
        private TextBox txtOutput;
        private TextBox txtInput;
        private TextBox txtConversion;
        private Button button2;
        private Label label4;
    }
}