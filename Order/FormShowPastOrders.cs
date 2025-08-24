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
    public partial class FormShowPastOrders : Form
    {
        int CustumerId;
        public FormShowPastOrders(int custumerId)
        {
            InitializeComponent();
            CustumerId = custumerId;
        }

        private void FormShowPastOrders_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=ClsOrder.GetPREOrders(CustumerId);
        }
    }
}
