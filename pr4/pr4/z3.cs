﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pr4
{
    public partial class z3 : Form
    {
        public z3()
        {
            InitializeComponent();
        }

        private void z3_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Введите\nваше имя");
            toolTip1.IsBalloon = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Здраствуй " + textBox1.Text + "!", "Приветствие");
        }
    }
}