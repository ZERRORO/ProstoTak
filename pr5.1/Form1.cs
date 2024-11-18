using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr51
{
 
public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pen_for_draw.StartCap = pen_for_draw.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private Bitmap bmp_for_draw;
        private Point start_point;
        private bool Draw;
        private Pen pen_for_draw = new Pen(Color.Black, 4);
        private string full_name_of_image;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files(*.*) | *.* ";
        if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    full_name_of_image = open_dialog.FileName;
                    bmp_for_draw = new Bitmap(open_dialog.FileName);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = bmp_for_draw;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Impossible to open selected file",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                string format = full_name_of_image.Substring(full_name_of_image.Length - 4, 4);
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как ...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF) | *.GIF | Image Files(*.PNG) | *.PNG | All files(*.*) | *.* ";
            savedialog.ShowHelp = true;
                // If selected, save
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bmp_for_draw.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Impossible to save image", "FATAL ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics Графика = pictureBox1.CreateGraphics(); Графика.Clear(SystemColors.Window);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics graf = Graphics.FromImage(pictureBox1.Image))
                {
                    graf.DrawLine(pen_for_draw, start_point, e.Location);
                    start_point = e.Location;
                    pictureBox1.Invalidate();
                }
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Draw = true;
                start_point = e.Location;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Draw = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Изменение картинки";
            button1.Text = "Обзор";
            button2.Text = "Сохранить";
            button3.Text = "Очистить";
        }
    }
}