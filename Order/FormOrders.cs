﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace furnitureStoreV2
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            dataGridView1.DataSource = BusinessLayer.ClsOrder.GetAllOrders();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
