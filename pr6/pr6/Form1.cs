using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr6
{
    public partial class Form1 : Form
    {
        Form2 fr2;
        public Form1()
        {
            InitializeComponent();
            fr2 = new Form2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string z = "Месяц " + a + "= " + b;
            listBox1.Items.Add(z);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox3.Text);
            double y = Convert.ToDouble(textBox4.Text);
            double z = x * y;
            textBox5.Text = z.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string m = comboBox1.SelectedItem.ToString();
            if(m =="Комбинированный"&& radioButton1.Checked == true)
            {double n = Convert.ToDouble(textBox6.Text); double s = n * 4.63; textBox7.Text = s.ToString();}
            if (m == "Комбинированный" && radioButton2.Checked == true)
            { double n = Convert.ToDouble(textBox6.Text); double s = n * 4.93; textBox7.Text = s.ToString();}
            if (m == "Дневной" && radioButton2.Checked == true)
            { double n = Convert.ToDouble(textBox6.Text); double s = n * 5.03; textBox7.Text = s.ToString(); }
            if (m == "Дневной" && radioButton1.Checked == true)
            { double n = Convert.ToDouble(textBox6.Text); textBox7.Text = "Не существует"; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fr2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
