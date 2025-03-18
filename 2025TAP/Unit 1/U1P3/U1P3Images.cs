using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITT2025_TAP
{
    public partial class U1P3Images : Form
    {
        string exc = "Error al guardar imagen";
        string success = "Imagen guardada con éxito";
        public U1P3Images()
        {
            InitializeComponent();
            InitializeTooltips();
        }
        private void InitializeTooltips()
        {
            tipLoadImage = new ToolTip();
            tipLoadImage.SetToolTip(this.btnLoadImage, "Imagen en formato .jpg/.jpeg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg";
            ofd.FileName = "";
            ofd.Title = "Titulo del Dialogo";
            ofd.InitialDirectory = "C:\\";
            ofd.FileName = this.ImageLocation.Text;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.ImageLocation.Text = ofd.FileName;
                string Direccion = ofd.FileName;
                this.pictureBox1.ImageLocation = Direccion;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\Public\Pictures\imagen.bmp",
                    System.Drawing.Imaging.ImageFormat.Bmp);
                MessageBox.Show(success);
            }
            catch (Exception)
            {
                MessageBox.Show(exc);
            }
        }

        private void btnConvertJpeg_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\Public\Pictures\imagen.jpg",
                    System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show(success);
            }
            catch (Exception)
            {
                MessageBox.Show(exc);
            }
        }
        
        private void btnConvertPng_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\Public\Pictures\imagen.png",
                    System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show(success);
            }
            catch (Exception)
            {
                MessageBox.Show(exc);
            }
        }

        private void btnConvertGif_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\Public\Pictures\imagen.gif",
                    System.Drawing.Imaging.ImageFormat.Gif);
                MessageBox.Show(success);
            }
            catch
            {
                MessageBox.Show(exc);
            }
        }
    }
}