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
    public partial class Form1 : Form
    {
        Image file;
        Bitmap bmp,bmpori;
        int width;
        int height;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
     
        public void button1_Click(object sender, EventArgs e)
        {
            DialogResult open = openFileDialog1.ShowDialog();
            if (open == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                bmp= new Bitmap(openFileDialog1.FileName);
                bmpori = new Bitmap(openFileDialog1.FileName);
                //Load gambar ke dalam picturebox
                pictureBox1.Image = file;
                //ambil dimensi gambar 
                 width = bmp.Width;
                 height = bmp.Height;

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //ambil nilai pixel
                    Color p = bmp.GetPixel(x, y);

                    //extract ARGB dari nilai p
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    double graylevel = (r+g+b)/3;
                    int kons = 50;
                    int logTrans = kons * (int)Math.Log(1 + graylevel);
                    bmp.SetPixel(x, y, Color.FromArgb(a, logTrans, logTrans, logTrans));

                }
            }
            pictureBox2.Image = bmp;

        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        public void btnNegative_Click(object sender, EventArgs e)
        {
          
            // negative
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //ambil nilai pixel
                    Color p = bmp.GetPixel(x, y);
                    
                    //extract ARGB dari nilai p
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //cari nilai negative nya 
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;
                   
                    //set nilai rgb yang baru ke dalam pixel
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
          
            pictureBox2.Image = bmp;
        }

		public void btnPower_Click(object sender, EventArgs e)
		{
			int Gamma = 5;
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					//ambil nilai pixel
					Color p = bmp.GetPixel(x, y);

					//extract ARGB dari nilai p
					int a = p.A;
					int r = p.R;
					int g = p.G;
					int b = p.B;

					double graylevel = (r + g + b) / 3;
					int C = 1;
					int powerLaw = C * ((int)graylevel ^ Gamma);

					bmp.SetPixel(x, y, Color.FromArgb(a, powerLaw, powerLaw, powerLaw));
				}
			}
			pictureBox2.Image = bmp;
		}

		private void btnPiecewise_Click(object sender, EventArgs e)
		{
			int lightest = 0;
			int darkest = 255;

			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					//ambil nilai pixel
					Color p = bmp.GetPixel(x, y);

					//extract ARGB dari nilai p
					int a = p.A;
					int r = p.R;
					int g = p.G;
					int b = p.B;

					int graylevel = (r + g + b) / 3;
					if (graylevel > lightest)
					{
						lightest = graylevel;
					}
					if (graylevel < darkest)
					{
						darkest = graylevel;
					}
				}
			}
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					//ambil nilai pixel
					Color p = bmp.GetPixel(x, y);

					//extract ARGB dari nilai p
					int a = p.A;
					int r = p.R;
					int g = p.G;
					int b = p.B;

					int graylevel = (r + g + b) / 3;
					int contrast = (graylevel - darkest) * (255 - 0) / (lightest - darkest);
					bmp.SetPixel(x, y, Color.FromArgb(a, contrast, contrast, contrast));

				}

			}
			pictureBox2.Image = bmp;
		}

		private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form3 frm3 = new Form3();
			frm3.Show();
		}

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnReset_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(openFileDialog1.FileName);
			pictureBox2.Image = bmp;
        }

    }
}
