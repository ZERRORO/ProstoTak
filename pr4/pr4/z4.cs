using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr4
{
    public partial class z4 : Form
    {
        public z4()
        {
            InitializeComponent();
        }

        private void z4_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.Text = this.Width.ToString() + " " + label1.Width.ToString();
            int X = (this.Width / 2) - (label1.Width / 2);
            label1.Location = new System.Drawing.Point(X, 66);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            int X = (this.Width / 2) - (label1.Width / 2);
            label1.Location = new System.Drawing.Point(X, 66);
        }
    }
}
