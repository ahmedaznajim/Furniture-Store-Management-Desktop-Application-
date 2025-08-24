using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using furnitureStoreV2.Product;

namespace furnitureStoreV2
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct product = new FormAddProduct();
            product.ShowDialog();
            dataGridView1.DataSource = ClsProduct.GetAllproducts();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
         dataGridView1.DataSource=   ClsProduct.GetAllproducts();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClsProduct.GetAllproducts();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                if (ClsProduct.Deleteproduct(Convert.ToInt32(selectedRow.Cells[0].Value)))
                {
                    MessageBox.Show("Done");
                    dataGridView1.DataSource = ClsProduct.GetAllproducts();

                }
                else
                {
                    MessageBox.Show("Faild");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Select a complete Row");

            }
        }

        private void storeInAWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

         FormStore f=new FormStore(Convert.ToInt32( selectedRow.Cells[0].Value));
            f.ShowDialog();

            
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewProductInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewProductInfo f = new FormViewProductInfo(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
            , Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value)
            , Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value)
            , Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value)
            ,Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value)
            ,Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value)
                );
            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
            {
                textBoxSerch.Enabled = true;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxSerch.Enabled = false;
                textBoxSerch.Text = "";
                dataGridView1.DataSource = ClsProduct.GetAllproducts();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = ClsProduct.SerchID(
               Convert.ToInt32(textBoxSerch.Text));
            }

            if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = ClsProduct.SerchName(Convert.ToString(textBoxSerch.Text));
            }
        }
    }
}
