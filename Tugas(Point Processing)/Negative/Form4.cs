using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negative
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Image file1, file2;
        Bitmap bmp, bmp2;
        int width1, width2, height1, height2;

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnExecuteXor_Click(object sender, EventArgs e)
        {
            int graylevel, graylevel2, grayfinal = 0;
            int a, x, y;
            try
            {
                //Looping Gambar 1
                for (y = 0; y < height1; y++)
                {
                    for (x = 0; x < width1; x++)
                    {
                        //ambil nilai pixel Gambar 1
                        Color p1 = bmp.GetPixel(x, y);

                        //extract ARGB dari nilai p1
                        a = p1.A;
                        int r1 = p1.R;
                        int g1 = p1.G;
                        int b1 = p1.B;

                        graylevel = (r1 + g1 + b1) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(a, graylevel, graylevel, graylevel));


                        //ambil nilai pixel Gambar 2
                        Color p2 = bmp2.GetPixel(x, y);
                        //extract ARGB dari nilai p2
                        a = p2.A;
                        int r2 = p2.R;
                        int g2 = p2.G;
                        int b2 = p2.B;

                        //set Treshold
                        if (graylevel < 128)
                        {
                            graylevel = 0;
                        }
                        else
                        {
                            graylevel = 1;
                        }
                        graylevel2 = (r2 + g2 + b2) / 3;
                        bmp2.SetPixel(x, y, Color.FromArgb(a, graylevel2, graylevel2, graylevel2));

                        if (graylevel2 > 130)
                        {
                            graylevel2 = 1;
                        }
                        else
                        {
                            graylevel2 = 0;
                        }

                        //Seleksi utama
                        if (graylevel > graylevel2)
                        {
                            grayfinal = graylevel;
                        }
                        if (graylevel < graylevel2)
                        {
                            grayfinal = graylevel2;
                        }
                        if (graylevel == graylevel2)
                        {
                            grayfinal = graylevel;
                        }

                        bmp.SetPixel(x, y, Color.FromArgb(a, grayfinal, grayfinal, grayfinal));
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                DialogResult dialog = MessageBox.Show("Panjang/lebar dari dua gambar tidak cocok" +
                    ", silahkan coba tukar gambar 1 dengan gambar 2.", "Gambar Error", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
            }
            pictureBox3.Image = bmp;
        }

        private void btnExecuteAnd_Click_1(object sender, EventArgs e)
        {
            int graylevel, graylevel2, grayfinal = 0;
            int a, x, y;

            try
            {
                //Looping Gambar 1
                for (y = 0; y < height1; y++)
                {
                    for (x = 0; x < width1; x++)
                    {
                        //ambil nilai pixel Gambar 1
                        Color p1 = bmp.GetPixel(x, y);

                        //extract ARGB dari nilai p1
                        a = p1.A;
                        int r1 = p1.R;
                        int g1 = p1.G;
                        int b1 = p1.B;

                        graylevel = (r1 + g1 + b1) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(a, graylevel, graylevel, graylevel));


                        //ambil nilai pixel Gambar 2
                        Color p2 = bmp2.GetPixel(x, y);
                        //extract ARGB dari nilai p2
                        a = p2.A;
                        int r2 = p2.R;
                        int g2 = p2.G;
                        int b2 = p2.B;


                        graylevel2 = (r2 + g2 + b2) / 3;
                        bmp2.SetPixel(x, y, Color.FromArgb(a, graylevel2, graylevel2, graylevel2));


                        //Seleksi utama
                        if (graylevel < graylevel2)
                        {
                            grayfinal = graylevel;
                        }
                        else if (graylevel >= graylevel2)
                        {
                            grayfinal = graylevel2;
                        }

                        bmp.SetPixel(x, y, Color.FromArgb(a, grayfinal, grayfinal, grayfinal));
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                DialogResult dialog = MessageBox.Show("Panjang/lebar dari dua gambar tidak cocok" +
                    ", silahkan coba tukar gambar 1 dengan gambar 2.", "Gambar Error", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
            }
            pictureBox3.Image = bmp;

        }

        private void btnExecuteOr_Click(object sender, EventArgs e) //Logika OR
        {
            int graylevel, graylevel2, grayfinal = 0;
            int a, x, y;

            try
            {
                //Looping Gambar 1
                for (y = 0; y < height1; y++)
                {
                    for (x = 0; x < width1; x++)
                    {
                        //ambil nilai pixel Gambar 1
                        Color p1 = bmp.GetPixel(x, y);

                        //extract ARGB dari nilai p1
                        a = p1.A;
                        int r1 = p1.R;
                        int g1 = p1.G;
                        int b1 = p1.B;

                        graylevel = (r1 + g1 + b1) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(a, graylevel, graylevel, graylevel));


                        //ambil nilai pixel Gambar 2
                        Color p2 = bmp2.GetPixel(x, y);
                        //extract ARGB dari nilai p2
                        a = p2.A;
                        int r2 = p2.R;
                        int g2 = p2.G;
                        int b2 = p2.B;


                        graylevel2 = (r2 + g2 + b2) / 3;
                        bmp2.SetPixel(x, y, Color.FromArgb(a, graylevel2, graylevel2, graylevel2));


                        //Seleksi utama
                        if (graylevel > graylevel2)
                        {
                            grayfinal = graylevel;
                        }
                        else if (graylevel <= graylevel2)
                        {
                            grayfinal = graylevel2;
                        }

                        bmp.SetPixel(x, y, Color.FromArgb(a, grayfinal, grayfinal, grayfinal));
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                DialogResult dialog = MessageBox.Show("Panjang/lebar dari dua gambar tidak cocok" +
                    ", silahkan coba tukar gambar 1 dengan gambar 2.", "Gambar Error", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
            }
            pictureBox3.Image = bmp;
        }

        private void btnOpen2_Click_1(object sender, EventArgs e)
        {
            DialogResult open = openFileDialog2.ShowDialog();
            if (open == DialogResult.OK)
            {
                file2 = Image.FromFile(openFileDialog2.FileName);
                bmp2 = new Bitmap(openFileDialog2.FileName);
                //Load gambar ke dalam picturebox
                pictureBox2.Image = file2;
                //ambil dimensi gambar 
                width2 = bmp2.Width;
                height2 = bmp2.Height;

            }
        }

        private void btnOpen1_Click_1(object sender, EventArgs e)
        {
            DialogResult open = openFileDialog2.ShowDialog();
            if (open == DialogResult.OK)
            {
                file1 = Image.FromFile(openFileDialog2.FileName);
                bmp = new Bitmap(openFileDialog2.FileName);
                //Load gambar ke dalam picturebox
                pictureBox1.Image = file1;
                //ambil dimensi gambar 
                width1 = bmp.Width;
                height1 = bmp.Height;

            }
        }

    }
}
