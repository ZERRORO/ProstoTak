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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new z1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new z2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new z3().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new z4().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new z5().Show();
        }
    }
}
