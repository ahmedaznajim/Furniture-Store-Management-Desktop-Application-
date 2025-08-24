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
    public partial class FormCurrentOrder : Form
    {
        int OrderID;
        public FormCurrentOrder( int OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
        }

        private void FormCurrentOrder_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=ClsOrder.GetCurrentOrder(OrderID);
        }
    }
}
