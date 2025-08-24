using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace furnitureStoreV2
{
    public partial class FormAddProduct : Form
    {
        string imagePath;
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonIN.Checked)
                {
                    if (ClsProduct.AddNewProduct(textBoxProductName.Text, Convert.ToInt32(textBoxQuantity.Text),
                        Convert.ToInt32(textBoxPrice.Text), 1, imagePath.ToString()) == -1)
                    {
                        MessageBox.Show("Faild");

                    }
                    else
                    {
                        MessageBox.Show("Done");
                        this.Hide();
                        this.Close();

                    }
                }
            

            
            if (radioButtonOut.Checked)
            {

                if (ClsProduct.AddNewProduct(textBoxProductName.Text, Convert.ToInt32(textBoxQuantity.Text),
                    Convert.ToInt32(textBoxPrice.Text), 0,  imagePath.ToString()) == -1)
                {
                    MessageBox.Show("Faild");

                }
                else
                {
                    MessageBox.Show("Done");

                }

            }
            }
            catch
            {

                MessageBox.Show("insert each value");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                 imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
