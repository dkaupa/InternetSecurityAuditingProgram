﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerNetworks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        whitelist whitelist = new whitelist();
        blacklist blacklist = new blacklist();

        private void button1_Click(object sender, EventArgs e)
        {
            whitelist.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            blacklist.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Who do you think we are??? Who need options noob!");
        }
    }
}
