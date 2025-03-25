using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace _2025TAP.Unit_3.U3P1
{
    public partial class U3P1Threads : Form
    {
        public U3P1Threads()
        {
            InitializeComponent();
        }
        private void U3P1Threads_Load(object sender, EventArgs e) { }

        Thread thread1;
        Thread thread2;
        Thread thread3;

        public void MoveObject(int option)
        {
            for (int i = 31; i < 501; i++)
            {
                if (option == 1)
                {
                    btnAlpha.BeginInvoke((Action)delegate
                    {
                        btnAlpha.SetBounds(5 + i, 92, 60, 35);
                        btnBravo.SetBounds(535 - i, 133, 60, 35);
                    });
                }
                else
                {
                    if (option == 3)
                    {
                        btnCharlie.BeginInvoke((Action)delegate
                        {
                            btnCharlie.SetBounds(5 + i, 174, 60, 35);
                            btnDelta.SetBounds(535 - i, 215, 60, 35);
                        });
                    }
                }
                Thread.Sleep(10);
            }
        }
        public void ProgressBar()
        {
            for (int i = 0; i < 101; i++)
            {
                progressBar1.BeginInvoke((Action)delegate
                {
                    progressBar1.Value = i;
                    txtPB.Text = i + "%";
                });
                Thread.Sleep(100);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(() => MoveObject(1)));
            thread1.Start();

            thread2 = new Thread(new ThreadStart(() => ProgressBar()));
            thread2.Start();

            thread3 = new Thread(new ThreadStart(() => MoveObject(3)));
            thread3.Start();
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            try
            {
                thread1.Suspend();
                thread2.Suspend();
                thread3.Suspend();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            try
            {
                thread1.Resume();
                thread2.Resume();
                thread3.Resume();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
