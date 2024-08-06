using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.pictureBox1.Size = new Size(trackBar1.Value, trackBar1.Value);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open";
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.Filter= "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }

        }
        private void RotateImage()
        {
            // Rotate the image by 90 degrees clockwise
            Image rotatedImage = RotateImageBy90DegreesClockwise(pictureBox1.Image);
            pictureBox1.Image = rotatedImage;
        }

        private Image RotateImageBy90DegreesClockwise(Image img)
        {
            // Create a new bitmap with rotated dimensions
            Bitmap rotatedBmp = new Bitmap(img.Height, img.Width);
            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                // Set rotation point to center of image
                g.TranslateTransform(img.Height / 2, img.Width / 2);
                g.RotateTransform(90);
                g.TranslateTransform(-img.Width / 2, -img.Height / 2);

                // Draw the original image onto the rotated bitmap
                g.DrawImage(img, new Point(0, 0));
            }
            return rotatedBmp;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            RotateImage();

        }
    }
}
