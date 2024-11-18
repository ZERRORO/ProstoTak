using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr8
{
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trade_25ip212DataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.trade_25ip212DataSet.Employee);
            //Interfac interfac = new Interfac();
            new Interfac().FIO = dataGridView1[1, 0].Value.ToString();
        }
    }
}
