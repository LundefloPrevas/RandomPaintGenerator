using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPaintGenerator
{
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {

            int width = Form1.EditWidth;
            int height = Form1.EditHeight;

            int AlphaARGB = Form1.ARGB_Alpha;
            int RedARGB = Form1.ARGB_Red;
            int GreenARGB = Form1.ARGB_Green;
            int BlueARGB = Form1.ARGB_Blue;

            //bitmap
            Bitmap bmp = new Bitmap(width, height);

            //Random number
            Random rand = new Random();

            //Create random pixels
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //generate random ARGB value
                    int a = rand.Next(AlphaARGB);
                    int r = rand.Next(RedARGB);
                    int g = rand.Next(GreenARGB);
                    int b = rand.Next(BlueARGB);

                    //set ARGB value
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }


            for (int y = 0; y < height/2; y++)
            {
                for (int x = width/2 - 3; x < width/2 + 3; x++)
                {
                    int a = rand.Next(256);
                    int c = rand.Next(256);

                    bmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, c));
                }
            }

            for (int y = height/2; y < height/2 + 6; y++)
            {
                for (int x = width/2; x < width; x++)
                {
                    int a = rand.Next(256);
                    int c = rand.Next(256);

                    bmp.SetPixel(x, y, Color.FromArgb(a, 0, c, 0));
                }
            }

            for (int y = height / 2; y < height / 2 + 6; y++)
            {
                for (int x = 0; x < width/2; x++)
                {
                    int a = rand.Next(256);
                    int c = rand.Next(256);

                    bmp.SetPixel(x, y, Color.FromArgb(a, c, 0, 0));
                }
            }

            //Load bmp in picturebox1
            pictureBox1.Image = bmp;

            //Save (write) random pixel image
            //bmp.Save("C:\\Users\\chlo\\Documents\\PaintFormFolder\\RandomPaint.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
