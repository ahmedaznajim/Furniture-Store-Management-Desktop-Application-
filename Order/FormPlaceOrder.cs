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
    public partial class FormPlaceOrder : Form
    {
        public FormPlaceOrder()
        {
            InitializeComponent();
        }

        private void FormPlaceOrder_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ClsProduct.GetAllproducts();
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row[1].ToString());


            }
        }
    }
}
