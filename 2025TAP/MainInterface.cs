using _2025TAP.Unit_1.U1P1;
using _2025TAP.Unit_2.U2P2;
using _2025TAP.Unit_2.U2P3;
using _2025TAP.Unit_2.U2P4;
using _2025TAP.Unit_3.U3P1;
using ITT2025_TAP.Unidad_1;

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

        private void btnU2P3_Click(object sender, EventArgs e)
        {
            U2P3CustomPanel u2p3 = new U2P3CustomPanel();
            u2p3.Show();
        }

        private void btnU2P4_Click(object sender, EventArgs e)
        {
            U2P4CustomPictureBox u2p4 = new U2P4CustomPictureBox();
            u2p4.Show();
        }

        private void btnU1P4_Click(object sender, EventArgs e)
        {
            U1P4SalaryCalculator u1p4 = new U1P4SalaryCalculator();
            u1p4.Show();
        }

        private void btnU3P1_Click(object sender, EventArgs e)
        {
            U3P1Threads u3p1 = new U3P1Threads();
            u3p1.Show();
        }
    }
}
