﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerNetworks
{
    public partial class whitelist : Form
    {
        public whitelist()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void removeFromBlacklist(object sender, MouseEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;

            if (treeView1.SelectedNode.Tag != "parent")
            {
                treeView1.Nodes.Remove(node);
            }
            else
            {
                MessageBox.Show("You cannot remove a category! To edit categories, access the \"______\" menu");
            }
            
        }
    }
}
