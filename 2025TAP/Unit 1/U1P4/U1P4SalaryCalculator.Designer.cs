namespace ITT2025_TAP.Unidad_1
{
    partial class U1P4SalaryCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U1P4SalaryCalculator));
            btnCalculate = new Button();
            btnClear = new Button();
            lblEmployeeName = new Label();
            lblMoneyPerHour = new Label();
            lblWorkedHours = new Label();
            txtEmployeeName = new TextBox();
            txtSalaryPerHour = new TextBox();
            txtWorkedHours = new TextBox();
            lblTotalSalary = new Label();
            rtxtResult = new RichTextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.YellowGreen;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalculate.Location = new Point(75, 282);
            btnCalculate.MaximumSize = new Size(150, 50);
            btnCalculate.MinimumSize = new Size(150, 50);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 50);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.Location = new Point(336, 282);
            btnClear.MaximumSize = new Size(150, 50);
            btnClear.MinimumSize = new Size(150, 50);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 50);
            btnClear.TabIndex = 1;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.BackColor = Color.Transparent;
            lblEmployeeName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblEmployeeName.Location = new Point(75, 66);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(216, 25);
            lblEmployeeName.TabIndex = 2;
            lblEmployeeName.Text = "Nombre del Empleado:";
            // 
            // lblMoneyPerHour
            // 
            lblMoneyPerHour.AutoSize = true;
            lblMoneyPerHour.BackColor = Color.Transparent;
            lblMoneyPerHour.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblMoneyPerHour.Location = new Point(125, 101);
            lblMoneyPerHour.Name = "lblMoneyPerHour";
            lblMoneyPerHour.Size = new Size(166, 25);
            lblMoneyPerHour.TabIndex = 3;
            lblMoneyPerHour.Text = "Sueldo por Hora:";
            // 
            // lblWorkedHours
            // 
            lblWorkedHours.AutoSize = true;
            lblWorkedHours.BackColor = Color.Transparent;
            lblWorkedHours.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblWorkedHours.Location = new Point(121, 135);
            lblWorkedHours.Name = "lblWorkedHours";
            lblWorkedHours.Size = new Size(170, 25);
            lblWorkedHours.TabIndex = 4;
            lblWorkedHours.Text = "Horas Trabajadas:";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(297, 68);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(200, 23);
            txtEmployeeName.TabIndex = 5;
            // 
            // txtSalaryPerHour
            // 
            txtSalaryPerHour.Location = new Point(297, 103);
            txtSalaryPerHour.Name = "txtSalaryPerHour";
            txtSalaryPerHour.Size = new Size(200, 23);
            txtSalaryPerHour.TabIndex = 6;
            // 
            // txtWorkedHours
            // 
            txtWorkedHours.Location = new Point(297, 137);
            txtWorkedHours.Name = "txtWorkedHours";
            txtWorkedHours.Size = new Size(200, 23);
            txtWorkedHours.TabIndex = 7;
            // 
            // lblTotalSalary
            // 
            lblTotalSalary.AutoSize = true;
            lblTotalSalary.BackColor = Color.Transparent;
            lblTotalSalary.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lblTotalSalary.Location = new Point(215, 19);
            lblTotalSalary.Name = "lblTotalSalary";
            lblTotalSalary.Size = new Size(155, 32);
            lblTotalSalary.TabIndex = 10;
            lblTotalSalary.Text = "Sueldo Total";
            // 
            // rtxtResult
            // 
            rtxtResult.Location = new Point(121, 195);
            rtxtResult.Name = "rtxtResult";
            rtxtResult.Size = new Size(320, 71);
            rtxtResult.TabIndex = 11;
            rtxtResult.Text = "";
            // 
            // U1P4SalaryCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 361);
            Controls.Add(rtxtResult);
            Controls.Add(lblTotalSalary);
            Controls.Add(txtWorkedHours);
            Controls.Add(txtSalaryPerHour);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblWorkedHours);
            Controls.Add(lblMoneyPerHour);
            Controls.Add(lblEmployeeName);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "U1P4SalaryCalculator";
            Text = "Calculador de Sueldo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnClear;
        private Label lblEmployeeName;
        private Label lblMoneyPerHour;
        private Label lblWorkedHours;
        private TextBox txtEmployeeName;
        private TextBox txtSalaryPerHour;
        private TextBox txtWorkedHours;
        private Label lblTotalSalary;
        private RichTextBox rtxtResult;
    }
}