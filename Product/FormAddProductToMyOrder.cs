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
    public partial class FormAddProductToMyOrder : Form
    {
        int productId;
        int OrderId;

        public FormAddProductToMyOrder(int productId, int orderId)
        {
            InitializeComponent();
            this.productId = productId;
            OrderId = orderId;

            labelOrderId.Text = orderId.ToString();
            labelProductID.Text = productId.ToString();
        }

        private void FormAddProductToMyOrder_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClsOrder.AddProductToMuOrder(productId, OrderId, Convert.ToInt32(textBoxQuantity.Text)) == -1)
                {
                    MessageBox.Show("Faild");


                }
                else
                {
                    MessageBox.Show("Done");

                }
            }
            catch
            {
                MessageBox.Show("Insert The Quentity");
                
            }

        }
    }
}
