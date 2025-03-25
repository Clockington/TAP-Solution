using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITT2025_TAP.Unidad_1
{
    public partial class U1P4SalaryCalculator : Form
    {
        public U1P4SalaryCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            double salaryPerHour = double.Parse(txtSalaryPerHour.Text);
            double workedHours = double.Parse(txtWorkedHours.Text);
            double totalSalary = salaryPerHour * workedHours;

            rtxtResult.Text = $"Nombre: {employeeName}" +
                $"\nSalario por Hora: {salaryPerHour}" +
                $"\nHoras Trabajadas: {workedHours}" +
                $"\nSalario: {totalSalary}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtResult.Text = "";
            txtEmployeeName.Text = "";
            txtSalaryPerHour.Text = "";
            txtWorkedHours.Text = "";
        }
    }
}
