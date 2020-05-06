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
    public partial class Form1 : Form
    {
        public static int EditWidth;
        public static int EditHeight;

        public static int ARGB_Alpha;
        public static int ARGB_Red;
        public static int ARGB_Green;
        public static int ARGB_Blue;

        public Form1()
        {
            InitializeComponent();
        }

        //Cloes the program
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Create Random generated Pixel Art #CoolAsFuck
        private void button_OK_Click(object sender, EventArgs e)
        {
            PaintForm Form2 = new PaintForm();

            if (textBox_WindowWidth.Text == "" || textBox_WindowWidth.Text == "0")
                Form1.EditWidth = 640;
            else
                Form1.EditWidth = int.Parse(textBox_WindowWidth.Text);

            if (textBox_WindowHeight.Text == "" || textBox_WindowHeight.Text == "0")
                Form1.EditHeight = 320;
            else
                Form1.EditHeight = int.Parse(textBox_WindowHeight.Text);

            Form1.ARGB_Alpha = this.trackBar_AlphaValue.Value;
            Form1.ARGB_Red = this.trackBar_RedValue.Value;
            Form1.ARGB_Green = this.trackBar_GreenValue.Value;
            Form1.ARGB_Blue = this.trackBar_BlueValue.Value;

            Form2.Show();
        }

        //Show value of track bar
        private void trackBar_AlphaValue_Scroll(object sender, EventArgs e)
        {
            this.lable_AlphaValue.Text = this.trackBar_AlphaValue.Value.ToString();
        }

        private void trackBar_RedValue_Scroll(object sender, EventArgs e)
        {
            this.label_RedValue.Text = this.trackBar_RedValue.Value.ToString();
        }

        private void trackBar_GreenValue_Scroll(object sender, EventArgs e)
        {
            this.label_GreenValue.Text = this.trackBar_GreenValue.Value.ToString();
        }

        private void trackBar_BlueValue_Scroll(object sender, EventArgs e)
        {
            this.label_BlueValue.Text = this.trackBar_BlueValue.Value.ToString();
        }
    }
}
