﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("얌");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("얌");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.label1.Text = "얌얌얌";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            MessageBox.Show("수리수리마수리");

        }
    }
}
