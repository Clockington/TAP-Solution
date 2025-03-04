namespace _2025TAP.Unit_1.U1P1
{
    partial class U1P1Interface
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            programasToolStripMenuItem = new ToolStripMenuItem();
            smiMoneyExchange = new ToolStripMenuItem();
            smiDaysSeconds = new ToolStripMenuItem();
            smiMultiplication = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, programasToolStripMenuItem, verToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(534, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // programasToolStripMenuItem
            // 
            programasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smiMoneyExchange, smiDaysSeconds, smiMultiplication });
            programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            programasToolStripMenuItem.Size = new Size(76, 20);
            programasToolStripMenuItem.Text = "Programas";
            // 
            // smiMoneyExchange
            // 
            smiMoneyExchange.Name = "smiMoneyExchange";
            smiMoneyExchange.Size = new Size(197, 22);
            smiMoneyExchange.Text = "Conversión de Moneda";
            smiMoneyExchange.Click += smiMoneyExchange_Click;
            // 
            // smiDaysSeconds
            // 
            smiDaysSeconds.Name = "smiDaysSeconds";
            smiDaysSeconds.Size = new Size(197, 22);
            smiDaysSeconds.Text = "Días a Segundos";
            smiDaysSeconds.Click += smiDaysSeconds_Click;
            // 
            // smiMultiplication
            // 
            smiMultiplication.Name = "smiMultiplication";
            smiMultiplication.Size = new Size(197, 22);
            smiMultiplication.Text = "Tabla de Multiplicar";
            smiMultiplication.Click += smiMultiplication_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 20);
            verToolStripMenuItem.Text = "Ver";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 14F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(430, 154);
            label1.TabIndex = 1;
            label1.Text = "Nombre: LANDGRAVE REZA ANGEL ELOY\r\n\r\nNo. Control: 20211798\r\n\r\nMateria: Tópicos Avanzados de Programación\r\n\r\nFecha: Marzo 1, 2025";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // U1P1Interface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 272);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "U1P1Interface";
            Text = "U1P1Interface";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem programasToolStripMenuItem;
        private ToolStripMenuItem smiMoneyExchange;
        private ToolStripMenuItem smiDaysSeconds;
        private ToolStripMenuItem smiMultiplication;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private Label label1;
    }
}