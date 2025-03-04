namespace CustomControlPanel
{
    public partial class MyPanel : Panel
    {
        public MyPanel()
        {
            InitializeComponent();
            this.Height = 220;
            this.Width = 640;
            this.Padding = new Padding(10);
            this.AutoScroll = false;
            this.BackColor = Color.SkyBlue;
            this.ForeColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            AddPanels();
        }
        private void AddPanels()
        {
            Panel Alpha = new Panel();
            Alpha.BorderStyle = BorderStyle.FixedSingle;
            Alpha.Location = new Point(10, 10);
            Alpha.Size = new Size(200,100);
            Alpha.BackColor = Color.Blue;
            Alpha.ForeColor = Color.White;
            this.Controls.Add(Alpha);

            Panel Bravo = new Panel();
            Bravo.BorderStyle = BorderStyle.Fixed3D;
            Bravo.Location = new Point(220, 10);
            Bravo.Size = new Size(200, 100);
            Bravo.BackColor = Color.Green;
            Bravo.ForeColor = Color.White;
            this.Controls.Add(Bravo);

            Panel Charlie = new Panel();
            Charlie.Text = "Panel 3";
            Charlie.Location = new Point(430, 10);
            Charlie.Size = new Size(200,100);
            Charlie.BackColor = Color.Yellow;
            Charlie.ForeColor = Color.Black;
            this.Controls.Add(Charlie);
            
            Panel Delta = new Panel();
            Delta.Text = "Panel 4";
            Delta.Location = new Point(220, 120);
            Delta.Size = new Size(200,100);
            Delta.BackColor = Color.Purple;
            Delta.ForeColor = Color.White;
            this.Controls.Add(Delta);
        }
    }
}
