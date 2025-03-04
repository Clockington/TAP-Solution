using _2025TAP.Unit_1.U1P1.DaysSeconds;
using _2025TAP.Unit_1.U1P1.Multiplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025TAP.Unit_1.U1P1
{
    public partial class U1P1Interface : Form
    {
        public U1P1Interface()
        {
            InitializeComponent();
        }

        private void smiMoneyExchange_Click(object sender, EventArgs e)
        {
            U1P1MoneyExchange formMoneyExchange = new U1P1MoneyExchange();
            formMoneyExchange.Show();
        }

        private void smiDaysSeconds_Click(object sender, EventArgs e)
        {
            U1P1DaysSeconds formDaysSeconds = new U1P1DaysSeconds();
            formDaysSeconds.Show();
        }

        private void smiMultiplication_Click(object sender, EventArgs e)
        {
            U1P1Multiplication formMultiplication = new U1P1Multiplication();
            formMultiplication.Show();
        }
    }
}
