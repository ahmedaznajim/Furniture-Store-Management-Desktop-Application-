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
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();
        }

        private void FormAddOrder_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ClsEmployee.GetAllEmployees();
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row[1].ToString());


            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
