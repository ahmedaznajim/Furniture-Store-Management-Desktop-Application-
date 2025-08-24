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

namespace furnitureStoreV2
{
    public partial class FormStore : Form
    {
        int Quantity;
        int ProductID;
        int WarehousID;

        public FormStore( int ProductID)
        {
            InitializeComponent();
          
            this.ProductID = ProductID;
           

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = ClsWarehouse.GetAllWarehouse();
            DataRow dr = dt.Rows[comboBox1.SelectedIndex];

            

            if (ClsProduct.Store(Convert.ToInt32(textBoxQuantity.Text), Convert.ToInt32(labelProductId.Text),
                   Convert.ToInt32(dr[0])) == -1)
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

        private void FormStore_Load(object sender, EventArgs e)
        {
            labelProductId.Text=Convert.ToString(ProductID);

            DataTable dt = new DataTable();
            dt = ClsWarehouse.GetAllWarehouse();
            foreach (DataRow row in dt.Rows)
            {
               comboBox1.Items.Add(row[1].ToString());
                
               
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
