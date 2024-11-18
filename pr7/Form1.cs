using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trade_25ip212DataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.trade_25ip212DataSet.Goods);
            string data = goodsTableAdapter.GetData().ToString();
            textBox1.Text = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goodsTableAdapter.Update(trade_25ip212DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);
        }
    }
}
