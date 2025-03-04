using _2025TAP.Unit_1.U1P1;

namespace _2025TAP
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void btnU1P1_Click(object sender, EventArgs e)
        {
            U1P1Interface u1p1 = new U1P1Interface();
            u1p1.Show();
        }
    }
}
