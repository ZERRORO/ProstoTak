using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr52
{
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
            AddOwnedForm(form2);
            AddOwnedForm(form3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            form2.Location = new Point(Right - 10, Bottom - 10);

        }
    }
}
