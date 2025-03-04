using _2025TAP.Unit_1.U1P1;
using _2025TAP.Unit_2.U2P2;

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

        private void btnU2P2_Click(object sender, EventArgs e)
        {
            U2P2CustomButton u2p2 = new U2P2CustomButton();
            u2p2.Show();
        }
    }
}
