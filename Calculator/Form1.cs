﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if (tbA.Text != String.Empty)
            {
                double a = double.Parse(tbA.Text);
                double b = double.Parse(tbB.Text);
                double c = a + b;
                tbKQ.Text = c.ToString();
            }
        }
    }
}
